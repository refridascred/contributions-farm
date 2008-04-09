using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data, long step)
        {
            long mix = 706;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (sample & 15)) + step;
            }
            return mix % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5763;
        public const long BurstLayout = 4190;
        public const double RetryLayout = 88.82;
    }
}
