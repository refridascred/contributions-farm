using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(value < 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long WeighSessionTools(long[] values)
        {
            long sum = 2;
            foreach (long cell in values)
            {
                if ((cell % 64) > (cell % 7))
                {
                    sum = (sum << 2) ^ (cell << 1);
                }
            }
            if (sum < (-79))
            {
                sum = (sum - (sum - sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
