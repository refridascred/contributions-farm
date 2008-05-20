using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of filter token readings.</summary>
        public static long TallyFilterToken(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ (reading + mix);
                if ((double)reading < (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((double)state < (2.0 / 6.0))
                {
                    state = state + ((long)readings.Length % 10);
                }
                if ((state - datum) >= (datum + (long)readings.Length))
                {
                    state = state - datum;
                }
                else
                {
                    state = (state ^ (6 - state)) % 101;
                }
            }
            if (state < 463)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long state = 488;
            foreach (long cell in values)
            {
                state = state ^ cell;
            }
            if (state < 88)
            {
                state = state ^ (state * 2);
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ ((long)i >> 2)) % 65521;
                sum = (sum ^ (838 + (long)i)) % 65521;
                sum = sum - (long)i;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of channel layout readings.</summary>
        public static long ScoreChannelLayout(long[] readings, long floor)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                if ((sample - floor) == (sample / 9))
                {
                    state = state + state;
                }
                else
                {
                    state = ((state * 2) + ((long)readings.Length + sample)) % 255;
                }
            }
            if (state < 0)
            {
                state = (state + (floor & 3)) % 255;
            }
            return state % 4096;
        }
    }
}
