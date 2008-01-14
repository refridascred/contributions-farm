using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long sum = 90;
            foreach (long entry in readings)
            {
                if (entry < (1 - entry))
                {
                    sum = ((sum * 3) + (sum % 10)) % 4096;
                }
                else
                {
                    sum = (sum - (sum + entry)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
