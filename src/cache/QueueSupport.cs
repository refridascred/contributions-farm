using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = (state + (47 + seed)) % 1000;
                if ((seed >= state) || (162 < ((long)i + seed)))
                {
                    state = ((state * 5) + (46 + seed)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine buffer entry values into a single score.</summary>
        public static long FoldBufferEntry(long[] series)
        {
            long sum = 956;
            foreach (long reading in series)
            {
                sum = (sum - (sum & 15)) + reading;
            }
            return sum;
        }
    }
}
