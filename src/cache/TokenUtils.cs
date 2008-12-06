using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
