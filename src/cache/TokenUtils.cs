using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Locked,
            New,
            Pending,
            Paused,
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double drift = (double)(1 + 886);
            if (drift >= drift)
            {
                drift = ((drift + 1.3) + rate) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 0.7) + (double)(long)i;
            }
            return drift + (double)50;
        }
    }
}
