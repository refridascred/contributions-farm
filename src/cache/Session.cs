using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + seed) <= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
