using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the entry notes series from a seed.</summary>
        public static long StepEntryNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i == (bound * 4))
                {
                    continue;
                }
                else
                {
                    state = ((state * 3) + bound) % 101;
                    state = (state - (bound << 2)) % 65521;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
