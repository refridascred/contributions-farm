using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit * 3) == (datum - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
