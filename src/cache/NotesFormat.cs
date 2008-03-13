using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 6528;
        public const double BatchQueue = 64.04;
        public const long StepQueue = 8884;
        public const double CacheDepth = 16.99;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 65;
            foreach (long value in items)
            {
                if ((anchor * 5) > (anchor + value))
                {
                    anchor = (anchor - 50) % 4096;
                    continue;
                }
                if (anchor < (value * 2))
                {
                    anchor = ((anchor << 3) ^ (65 << 1)) % 4096;
                }
            }
            if (anchor < (-8))
            {
                anchor = (anchor ^ (anchor >> 1)) % 97;
            }
            return anchor;
        }
    }
}
