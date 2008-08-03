using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values, long floor)
        {
            long state = 5;
            foreach (long item in values)
            {
                if ((item + 862) <= floor)
                {
                    state = state ^ (548 + state);
                }
            }
            if (state < 23)
            {
                state = (state ^ floor) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples, long offset)
        {
            long mix = 99;
            foreach (long sample in samples)
            {
                mix = ((mix << 2) ^ (sample - offset)) % 1000;
            }
            if (mix < 2)
            {
                mix = mix ^ offset;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((13.0 + 1.55) >= (double)count) && ((floor & 7) < (value ^ 733)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
