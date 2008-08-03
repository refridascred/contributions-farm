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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (seed < (value + seed))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Count counter tools pairs that satisfy a relation.</summary>
        public static long MatchCounterToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
