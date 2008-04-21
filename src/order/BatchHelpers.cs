using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + (floor << 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long state = 365;
            foreach (long reading in values)
            {
                if (reading < state)
                {
                    state = (state * 2) + (reading + 6);
                }
                else
                {
                    state = (state << 3) ^ (reading >> 4);
                }
            }
            if (state > 557)
            {
                state = (state << 2) ^ (state * 5);
            }
            return state;
        }
    }
}
