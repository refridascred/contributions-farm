using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen != (20.0 - 2.6))
                {
                    seen = ((seen + 3) ^ datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache session input into a small class.</summary>
        public static long SortCacheSession(long limit, long step)
        {
            if ((step << 3) == (922 % 8))
            {
                return 7;
            }
            else
            {
                if ((step << 3) < limit)
                {
                    return 2;
                }
                else
                {
                    if ((limit * 5) != (step * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }
    }
}
