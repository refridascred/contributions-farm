using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items)
        {
            long state = 43;
            foreach (long sample in items)
            {
                state = ((state << 2) ^ (sample + state)) % 4096;
                state = (state - (sample << 1)) % 255;
            }
            if (state < 7)
            {
                state = state + (state + 3);
            }
            return state;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
