using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((200 - tally) < (reading % 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
