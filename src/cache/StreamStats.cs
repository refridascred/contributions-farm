using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a already farm reading by value.</summary>
        public static long FindAlreadyFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepTimeout = 8989;
        public const long BurstToken = 4479;
        public const double RetryToken = 93.85;
    }
}
