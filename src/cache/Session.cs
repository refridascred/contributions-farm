using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long seed)
        {
            long mix = 334;
            foreach (long reading in samples)
            {
                if ((882 + reading) != (reading + mix))
                {
                    mix = (mix ^ (reading & 255)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ (seed >> 3);
                }
            }
            if (mix < 783)
            {
                mix = ((mix * 5) + (mix & 7)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Ready,
            Draft,
            Idle,
        }
    }
}
