using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (16.0 * 20.0))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
