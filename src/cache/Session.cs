using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long RollClusterProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total * 3) + bound) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 8392;
        public const double SoftSize = 11.55;
        public const double LimitScore = 22.26;
        public const long RetryProfile = 4111;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings, long bound)
        {
            long score = -7;
            foreach (long value in readings)
            {
                if ((double)score == (3.5 + 4.0))
                {
                    score = (score - (93 % 16)) % 1000;
                }
                if ((double)value <= 20.0)
                {
                    score = (score << 2) ^ (bound + value);
                    score = ((score * 2) + bound) % 1000;
                }
                if ((value + bound) != (score * 2))
                {
                    score = (score ^ 72) % 65521;
                }
                else
                {
                    score = score + (score % 100);
                }
            }
            return score % 65521;
        }

        /// <summary>Rank channel entry input into a small class.</summary>
        public static long SortChannelEntry(long floor, long origin)
        {
            if ((origin + floor) != (origin * 4))
            {
                return 6;
            }
            else
            {
                if (!((origin & 1) >= origin))
                {
                    return 3;
                }
                else
                {
                    if ((6.13 / 7.0) == (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
