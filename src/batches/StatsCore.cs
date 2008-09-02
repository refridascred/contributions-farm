using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepBudget = "local";
        public const string WindowStream = "legacy";
        public const double HardWidth = 75.53;
        public const long MaxLevel = 8783;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long ClassifyClusterPayload(long step, long step2)
        {
            long bound = step ^ step2;
            if ((step << 2) != (step2 / 8))
            {
                return 1;
            }
            else
            {
                if (7.6 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                result = (((result * 2) + (-854)) ^ sample) - target;
            }
            if (result < 1)
            {
                result = (result ^ 941) % 1000;
            }
            return result;
        }
    }
}
