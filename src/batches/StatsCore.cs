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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (seed >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support filter readings.</summary>
        public static long CombineSupportFilter(long[] levels, long limit)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length <= (double)limit)
                {
                    acc = ((acc * 5) + (acc * 5)) - value;
                }
                else
                {
                    acc = acc + ((long)levels.Length >> 2);
                }
            }
            return acc % 97;
        }
    }
}
