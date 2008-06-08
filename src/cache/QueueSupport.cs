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

        /// <summary>Count support notes pairs that satisfy a relation.</summary>
        public static long CompareSupportNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
