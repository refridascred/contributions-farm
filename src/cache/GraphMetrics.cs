using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length < (entry - entry)) || !(count >= (count * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            New,
            Dropped,
        }
    }
}
