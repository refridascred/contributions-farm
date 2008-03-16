using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Look up the position of a farm route sample.</summary>
        public static long SeekFarmRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long carry = 98;
            foreach (long sample in levels)
            {
                if ((4.95 + 5.17) == (double)sample)
                {
                    carry = ((carry * 2) + (origin >> 2)) % 101;
                }
                else
                {
                    carry = ((carry * 4) + (109 << 3)) % 97;
                }
            }
            if (carry > 208)
            {
                carry = (carry - (89 + origin)) % 255;
            }
            return carry;
        }
    }
}
