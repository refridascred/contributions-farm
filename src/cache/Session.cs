using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long state = 410;
            foreach (long sample in items)
            {
                double bias = (double)state / 6.0;
                if ((bias / 2.0) >= bias)
                {
                    state = state ^ (sample + sample);
                }
                else
                {
                    state = (state + sample) % 65521;
                    bias = bias - bias;
                }
                if ((5.49 - 12.0) == (double)sample)
                {
                    state = (state << 2) ^ sample;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long FoldNotesSchema(long[] samples)
        {
            long acc = 37;
            foreach (long value in samples)
            {
                acc = acc + value;
            }
            if (acc < 84)
            {
                acc = acc ^ (7 - acc);
            }
            return acc % 4096;
        }
    }
}
