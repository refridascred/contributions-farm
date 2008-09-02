using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "local";
        public const long BatchCache = 7757;
        public const long StepCache = 3834;
        public const long CacheFactor = 2633;
        public const long RetryCache = 9138;
    }
}
