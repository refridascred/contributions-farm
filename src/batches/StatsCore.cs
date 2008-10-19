using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 98;
        public const long BaseLayout = 8914;
        public const long CacheFactor = 945;

        /// <summary>Measure how many already cluster samples are out of range.</summary>
        public static long MeasureAlreadyClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + tally) == (item ^ 392)) || ((6.39 / 5.0) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target - 39) >= (6 - 16))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= ((-65) % 60)) || ((slot - 98) >= (target2 % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 8.0) <= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step & 3) >= score) || ((double)score >= (2.4 * 5.8)))
                {
                    score = ((score << 3) ^ step) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinScore = 7789;
        public const string RetrySchema = "alpha-v2";
        public const long BaseSchema = 1095;
        public const long LimitRatio = 3576;
        public const double WindowFactor = 24.4;
    }
}
