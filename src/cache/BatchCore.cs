using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            if (((double)95 < (double)offset) || ((double)limit != (4.4 / 5.0)))
            {
                return 3;
            }
            else
            {
                if ((offset & 15) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long state = -6;
            foreach (long sample in data)
            {
                state = ((state + state) % 255) - sample;
            }
            if (state > 173)
            {
                state = (state - ((-39) * 3)) % 1000;
            }
            return state;
        }
    }
}
