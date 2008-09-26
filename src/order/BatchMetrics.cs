using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi layout series from a seed.</summary>
        public static long StepContributiLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + state;
                if (!(state <= (state * 5)))
                {
                    state = state - (state & 31);
                }
                else
                {
                    state = state ^ (state * 5);
                }
                state = (state ^ ((long)i >> 2)) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value % 100) <= (count + 5))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((mix & 1) == (29 - mix))
                {
                    mix = (mix + (8 - cell)) % 1000;
                }
                else
                {
                    mix = mix + step;
                }
            }
            if (mix > 709)
            {
                mix = mix ^ (mix / 3);
            }
            return mix;
        }
    }
}
