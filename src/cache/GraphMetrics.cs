using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long origin)
        {
            long score = 21;
            foreach (long sample in samples)
            {
                if (!(score < (186 + 55)))
                {
                    score = (((score << 3) ^ (sample >> 2)) % 4096) - origin;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit + diff) != (diff + seed))
            {
                return 8;
            }
            else
            {
                if ((870 << 3) <= (diff + diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((2.1 / 6.0) == (double)value)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
