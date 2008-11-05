using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
