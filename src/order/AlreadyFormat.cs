using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ seed) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstTimeout = "fallback-v2";
        public const string MaxPayload = "standard-1";
        public const string WindowPayload = "strict-edge";
        public const long DefaultPayload = 3639;
        public const long StepCount = 9290;

        /// <summary>Grade a filter channel value against two limits.</summary>
        public static long BucketFilterChannel(long bound, long bound2)
        {
            if (!((bound2 - bound2) >= (bound2 * 3)))
            {
                return 7;
            }
            else
            {
                if ((double)bound2 > (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
