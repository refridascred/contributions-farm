using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading & 63) == (reading - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
