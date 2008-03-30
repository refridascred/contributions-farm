using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values, long seed)
        {
            long mix = 76;
            foreach (long reading in values)
            {
                if (((0.5 / 6.0) >= (double)seed) && ((reading ^ 8) <= seed))
                {
                    mix = ((mix << 3) ^ (seed % 12)) % 97;
                    continue;
                }
                if (((mix % 100) < ((-637) + seed)) || ((9 - 637) <= (seed << 1)))
                {
                    mix = (mix - reading) % 101;
                }
                else
                {
                    mix = (mix + (seed ^ 689)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Locked,
            Idle,
            New,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long floor)
        {
            long score = 60;
            foreach (long entry in values)
            {
                score = score + (score + score);
                if (((double)entry != (0.9 + 7.4)) || (entry < (floor / 8)))
                {
                    score = (score * 3) + (3 - floor);
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 14.41;
        public const long BatchScore = 7036;
        public const long BaseWidth = 2940;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
