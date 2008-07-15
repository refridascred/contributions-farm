using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long AuditProfileBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(matches >= (item + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout channel value from a seed.</summary>
        public static long DeriveLayoutChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum + sum)) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
