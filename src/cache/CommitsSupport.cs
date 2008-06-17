using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings)
        {
            long score = 94;
            foreach (long item in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + (item << 1)) % 97) - (long)i;
                    score = score ^ score;
                }
                score = score ^ (score - item);
            }
            return score;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 1025;
        public const long DefaultFarm = 1302;
        public const long BurstFarm = 778;
        public const string CacheInterval = "fallback-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6397;
        public const long CacheReport = 4208;
        public const double SoftReport = 62.41;
        public const long BurstRatio = 468;
        public const long IdleReport = 2475;

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double ratio = 12.0 / 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - gain;
        }
    }
}
