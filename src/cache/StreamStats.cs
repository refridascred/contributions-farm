using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next filter context value.</summary>
        public static double BlendFilterContext(double ratio, double span)
        {
            double ratio2 = (double)(-787) / 9.0;
            if (ratio2 > span)
            {
                ratio2 = ratio2 + (ratio2 + 5.0);
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + (9.3 * 7.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Digest a series of format contributi entries.</summary>
        public static long WeighFormatContributi(long[] series)
        {
            long mark = 62;
            foreach (long reading in series)
            {
                if (((9.99 - 0.5) <= (double)reading) && (reading >= (reading - mark)))
                {
                    mark = ((mark * 2) + (reading + 909)) % 4096;
                }
                if (!(((long)series.Length & 7) > reading))
                {
                    mark = (mark * 2) + reading;
                }
                mark = (mark << 3) ^ (reading - (long)series.Length);
            }
            return mark;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
