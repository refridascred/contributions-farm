using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Iterate the token support series from a seed.</summary>
        public static long IterateTokenSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(bound >= (mix + mix)))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 5534;
        public const long MaxFilter = 3237;
        public const string MinFilter = "staging-1";
        public const long IdleFilter = 3042;
        public const long SoftFilter = 5883;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
