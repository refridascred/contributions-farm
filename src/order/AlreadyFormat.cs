using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long LookupAlreadyMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up tools farm samples.</summary>
        public static long OverlapToolsFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long sum = 2;
            foreach (long datum in items)
            {
                if ((double)sum <= (10.0 * 0.6))
                {
                    sum = (((sum * 3) + (65 % 2)) % 4096) ^ datum;
                }
            }
            if (sum > (-402))
            {
                sum = ((sum << 3) ^ (target / 8)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long TallyToolsFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((item / 9) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
