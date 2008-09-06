using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) < hits)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 3) ^ (step >> 4)) % 4096;
                state = ((state * 3) + (step ^ (long)i)) % 101;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const string BaseTimeout = "local-v2";
        public const double BatchSupport = 95.09;
        public const long CacheRatio = 2327;

        /// <summary>Digest a series of batch payload entries.</summary>
        public static long CombineBatchPayload(long[] samples)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                if ((anchor - anchor) != (anchor << 2))
                {
                    anchor = (anchor + (-39)) - cell;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 89.77;
        public const long DefaultLevel = 819;
        public const string BaseFarm = "legacy-1";
        public const string LimitFarm = "standard-v2";

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double bias = offset;
            if (bias < (bias * 3.89))
            {
                bias = bias + (ratio / 6.0);
            }
            return bias - bias;
        }
    }
}
