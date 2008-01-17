using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a account entry counter forward.</summary>
        public static long SeriesAccountEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((8 & 255) <= offset) || ((10.0 + 2.6) >= (double)anchor))
                {
                    anchor = (anchor - ((-50) - anchor)) % 1000;
                }
                anchor = (anchor - (anchor % 97)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Locked,
            Active,
        }
    }
}
