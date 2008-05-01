using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 8.7)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ state) % 1000) + entry) + origin;
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels)
        {
            long carry = 96;
            foreach (long sample in levels)
            {
                carry = ((carry + carry) % 4096) ^ sample;
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            New,
            Idle,
            Stale,
            Done,
        }
    }
}
