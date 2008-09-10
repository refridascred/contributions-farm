using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 + 58) > (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics cluster series from a seed.</summary>
        public static long SeriesMetricsCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if (score <= bound)
                {
                    score = (score ^ ((long)i * 3)) % 4096;
                    score = (score ^ ((-76) - (long)i)) % 97;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "stable";
        public const double HardToken = 14.95;
        public const string MaxToken = "alpha-v2";
        public const long StepScore = 9622;
        public const long StepToken = 5133;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Grade a channel command value against two limits.</summary>
        public static long BucketChannelCommand(long floor, long bound)
        {
            long gap = floor + bound;
            if ((bound - (-5)) >= (floor - gap))
            {
                return 4;
            }
            else
            {
                if ((9 / 6) > (77 + bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound & 7) > gap) || ((floor & 7) <= (gap + (-386))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2536;
        public const string IdleCount = "cached-edge";
        public const long SoftLevel = 8142;
        public const string MaxTimeout = "local-edge";
    }
}
