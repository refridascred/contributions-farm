using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings, long limit)
        {
            long total = 37;
            foreach (long sample in readings)
            {
                if ((2 - sample) < (limit >> 5))
                {
                    total = (total + (sample % 24)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
