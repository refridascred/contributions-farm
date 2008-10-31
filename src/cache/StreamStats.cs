using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long TallyBufferEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= (matches / 2))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "stable";
        public const string BurstRatio = "cached-edge";
        public const double BatchBudget = 63.71;
        public const long SoftLayout = 219;

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxBudget = "stable-1";
        public const long BatchToken = 2063;
        public const double CacheToken = 87.37;
    }
}
