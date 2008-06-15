using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor * 2) + (1 - (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.76 * 5.0) >= (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
