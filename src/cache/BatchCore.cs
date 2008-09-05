using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((-2) * 2) == ((long)i & 63))
                {
                    sum = (sum * 2) + (sum - limit);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum - sum) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Idle,
            Retry,
            Stale,
        }
    }
}
