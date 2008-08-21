using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 57.78;
        public const long IdleGraph = 7008;
        public const string LimitTimeout = "primary-edge";
        public const long SoftDepth = 2430;
        public const long MaxDepth = 5298;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits << 2) <= (1 * 5))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Queued,
            Synced,
        }
    }
}
