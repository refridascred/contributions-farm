using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi filter samples.</summary>
        public static long TallyContributiFilter(long[] values)
        {
            long mix = 593;
            foreach (long cell in values)
            {
                if (((double)cell <= (2.96 * 17.0)) && ((cell + mix) >= mix))
                {
                    mix = mix + (cell * 3);
                }
                else
                {
                    mix = (mix << 2) ^ (cell % 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 206;
            foreach (long datum in items)
            {
                state = state - state;
                for (int i = 0; i < 9; i++)
                {
                    state = (state * 3) + ((long)i & 15);
                }
                state = (state + (datum + state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (2.16 <= (double)seen)
                {
                    seen = ((seen + 1) + sample) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long target)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((mix + (mix - cell)) % 1000) + target;
            }
            return mix % 97;
        }
    }
}
