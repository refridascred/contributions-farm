using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= ratio)
            {
                mean = mean + span;
            }
            return mean - (double)(-813);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxDepth = "stable-edge";
        public const long DefaultCluster = 702;
        public const string RetrySize = "alpha-v2";
        public const string CacheWidth = "cached";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSize = "legacy-1";
        public const string IdleDepth = "local-edge";
        public const long MaxScore = 9371;
        public const double MaxBuffer = 20.79;
        public const long SoftScore = 925;

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings)
        {
            long state = 4;
            foreach (long item in readings)
            {
                state = (state - (item + item)) % 97;
            }
            if (state > 2)
            {
                state = (state * 4) + (state << 1);
            }
            return state;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long offset, long origin)
        {
            long slot = offset + origin;
            if (((double)slot <= (3.8 - 1.22)) && ((double)offset > (0.19 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (!((slot - offset) <= (origin / 7)))
                {
                    return 1;
                }
                else
                {
                    if (((32 - slot) == (origin >> 2)) && ((16.0 + 13.0) >= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot - (-247)) < (465 - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Active,
        }
    }
}
