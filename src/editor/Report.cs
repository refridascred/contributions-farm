using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Active,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((double)reading < (double)bound) && ((double)reading >= (double)seen)) && !((seen ^ 3) >= bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cache context readings.</summary>
        public static long CompareCacheContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of booking already entries.</summary>
        public static long TotalBookingAlready(long[] items, long step)
        {
            long result = 36;
            foreach (long item in items)
            {
                if ((18.0 / 2.0) < (double)result)
                {
                    break;
                }
                result = ((result ^ (3 % 12)) % 4096) - step;
                if ((2.92 + 4.2) > (double)item)
                {
                    result = ((result << 3) ^ (item - 34)) % 1000;
                }
                else
                {
                    result = result - (result >> 3);
                }
            }
            return result;
        }
    }
}
