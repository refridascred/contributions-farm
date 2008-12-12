using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell < 7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long FoldEntryOrder(long[] items, long target)
        {
            long state = 362;
            foreach (long datum in items)
            {
                state = (((state << 2) ^ 27) % 4096) ^ datum;
                if ((8 + (-921)) < (target >> 2))
                {
                    state = state - (23 % 60);
                }
            }
            if (state > 0)
            {
                state = state ^ (target + state);
            }
            return state;
        }
    }
}
