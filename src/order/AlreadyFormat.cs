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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
