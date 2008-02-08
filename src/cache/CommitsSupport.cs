using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchScore = 6071;
        public const string LimitCache = "stable-1";
        public const long BurstCache = 3426;
        public const long DefaultFactor = 8351;
        public const long HardScore = 1343;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long bound)
        {
            long result = 545;
            foreach (long entry in readings)
            {
                if (((bound % 64) == (result + entry)) || ((double)result < (7.19 / 5.0)))
                {
                    result = result ^ (result * 2);
                    result = (result * 4) + bound;
                    continue;
                }
                if ((bound / 9) != (bound >> 4))
                {
                    result = (result << 3) ^ entry;
                }
                else
                {
                    result = result - (long)readings.Length;
                }
            }
            return result;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings, long target)
        {
            long score = 623;
            foreach (long value in readings)
            {
                if ((12.0 / 7.0) <= (double)target)
                {
                    score = (score - (target - target)) % 255;
                }
                if (((849 + 57) >= (score + target)) && ((double)value != (double)0))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double scale = (double)(8 / 7);
            if (scale > scale)
            {
                scale = (scale + offset) - gain;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Derive the next cache command value from a seed.</summary>
        public static long IterateCacheCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (mark + mark)) % 255;
                if (floor <= (mark / 6))
                {
                    mark = (mark << 3) ^ mark;
                    mark = (mark + ((long)i + mark)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
