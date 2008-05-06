using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series, long limit)
        {
            long mix = 66;
            foreach (long reading in series)
            {
                if (47 < (reading - (-60)))
                {
                    mix = ((mix * 4) + (limit + reading)) % 255;
                }
                else
                {
                    mix = mix + limit;
                }
            }
            return mix;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
