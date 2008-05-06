using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Draft,
            New,
            Paused,
            Done,
        }

        /// <summary>Measure how many filter commits samples are out of range.</summary>
        public static long MeasureFilterCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!((reading >> 5) >= ((long)readings.Length << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Active,
            Pending,
            Stale,
        }
    }
}
