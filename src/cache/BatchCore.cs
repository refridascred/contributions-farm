using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix > 12.0)
                {
                    mix = (mix << 3) ^ (mix + 387);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Draft,
        }
    }
}
