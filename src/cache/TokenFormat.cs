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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
