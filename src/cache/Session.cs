using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((double)tally != (5.2 + 2.8)) || ((1.12 + 13.0) > (double)tally)) && ((6 - tally) <= 7))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (33 - 594)) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
