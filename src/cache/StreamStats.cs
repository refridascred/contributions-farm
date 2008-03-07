using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (rate * 9.2))
            {
                scale = scale - (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale - offset);
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Retry,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 79.18;
        public const long CacheCount = 2945;
        public const long SoftFactor = 8799;
        public const double SoftScore = 49.19;
        public const double IdleFactor = 93.66;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
