using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long limit)
        {
            long acc = 530;
            foreach (long sample in readings)
            {
                acc = (acc + limit) ^ sample;
            }
            if (acc < 118)
            {
                acc = ((acc * 2) + (0 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples)
        {
            long state = 54;
            foreach (long sample in samples)
            {
                if ((double)state >= (double)sample)
                {
                    state = (state * 3) + (state + sample);
                }
            }
            if (state > 9)
            {
                state = (state - state) % 255;
            }
            return state % 4096;
        }
    }
}
