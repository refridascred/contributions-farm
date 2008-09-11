using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state - (state >> 5)) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long target)
        {
            long state = 208;
            foreach (long sample in samples)
            {
                state = (((state * 3) + (-408)) - sample) - target;
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 97;
            foreach (long item in values)
            {
                if ((double)item <= (15.0 + 9.88))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 4) + ((long)i2 << 2)) % 255;
                    mix = ((mix * 3) + (mix - 28)) % 65521;
                }
                if ((double)mix <= (double)limit)
                {
                    mix = (mix + ((long)i + (long)i)) % 97;
                    mix = mix + (limit ^ (long)i);
                }
                if ((double)limit > (5.0 - 2.17))
                {
                    mix = (mix - (limit + 37)) % 97;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
