using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a buffer payload figure with a bias.</summary>
        public static double SmoothBufferPayload(double weight, double bias)
        {
            double ratio = weight;
            return (ratio - (weight * 5.9)) + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 433;
        public const double BatchSupport = 84.39;
        public const double BaseSupport = 67.0;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long TallyBufferWindowMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((origin + value) > (matches % 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardWidth = 46.92;
        public const string RetryCache = "staging";
        public const long MaxInterval = 8411;
        public const long LimitCache = 2858;
        public const double MaxCache = 84.1;
    }
}
