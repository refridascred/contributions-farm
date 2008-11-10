using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 315;
            foreach (long sample in levels)
            {
                state = ((state * 5) + (sample >> 1)) % 97;
                if (state > (sample >> 2))
                {
                    state = (state ^ (state + state)) % 1000;
                }
            }
            return state;
        }
    }
}
