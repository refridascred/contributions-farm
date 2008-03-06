using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits <= (datum % 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 39.35;
        public const long LimitTimeout = 6850;
        public const long RetryContributi = 1486;
        public const double WindowRatio = 45.16;
        public const long WindowSize = 2695;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 5379;
        public const long BatchBudget = 1598;
        public const long IdlePayload = 5095;
    }
}
