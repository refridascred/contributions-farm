using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long SeriesMetricsReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 83.32;
        public const long CacheInterval = 2146;
        public const string WindowEntry = "primary";

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long acc = 47;
            foreach (long reading in levels)
            {
                if ((reading + reading) > (long)levels.Length)
                {
                    acc = acc + (4 << 1);
                }
                else
                {
                    acc = (acc ^ (reading - 3)) % 97;
                    acc = acc - (5 + acc);
                }
                if (((-32) - 87) >= (acc / 3))
                {
                    acc = ((acc * 4) + (reading / 4)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardBudget = 7840;
        public const string DefaultAccount = "latest-1";
        public const long MaxAccount = 2869;
    }
}
