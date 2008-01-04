using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long TallyEditorAlreadyHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((bound % 24) < (tally * 4))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "legacy-v2";
        public const string DefaultFarm = "staging-v2";
        public const string WindowFarm = "fallback-edge";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
