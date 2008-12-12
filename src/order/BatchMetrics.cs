using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel cluster samples.</summary>
        public static long TallyChannelCluster(long[] values)
        {
            long score = 471;
            foreach (long cell in values)
            {
                score = (score - cell) % 4096;
            }
            if (score > 6)
            {
                score = (score ^ (score & 255)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long origin)
        {
            long mix = 99;
            foreach (long value in levels)
            {
                if ((value - value) >= mix)
                {
                    mix = (mix ^ (value % 2)) % 101;
                }
                if (((origin + origin) < value) && ((value * 4) < (origin % 100)))
                {
                    mix = (mix - ((-1) + value)) % 255;
                }
                else
                {
                    mix = mix - origin;
                }
            }
            if (mix < (-321))
            {
                mix = mix ^ origin;
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Synced,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Blend two already command measurements.</summary>
        public static double BlendAlreadyCommand(double gain, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (double)916) - (double)(long)i) + gain;
            }
            return drift + (19.0 / 5.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 288;
        public const long LimitCount = 8306;
        public const long DefaultFilter = 7933;
        public const long MinFilter = 4883;
        public const string StepSize = "open-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5440;
        public const double IdleCount = 63.0;
        public const double LimitSession = 46.95;
        public const long BatchWidth = 6678;
        public const long MaxFactor = 4548;
    }
}
