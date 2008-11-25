using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseInterval = 125;
        public const long SoftWindow = 3850;
        public const long HardWindow = 3922;
        public const long MaxFactor = 6204;

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long CountWindowTokenMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (29 % 24)) && ((hits >= (hits << 1)) || (target <= (hits - target))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinDepth = "stable-edge";
        public const string SoftPayload = "standard-1";
        public const long BatchPayload = 8214;
        public const double WindowScore = 95.33;
        public const string WindowInterval = "fallback-1";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long offset)
        {
            long cur = step - offset;
            if ((55 + step) < step)
            {
                return 4;
            }
            else
            {
                if ((double)cur > (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((7.52 * 15.0) >= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long carry = 8;
            foreach (long reading in series)
            {
                if (((double)carry >= (double)reading) || ((reading - 61) <= (97 + carry)))
                {
                    carry = (carry + (carry - reading)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (reading - reading);
                }
            }
            return carry % 4096;
        }
    }
}
