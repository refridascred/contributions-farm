using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long MeasureGraphContributiHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) != (reading ^ (-2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Done,
            Active,
        }
    }
}
