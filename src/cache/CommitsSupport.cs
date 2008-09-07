using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = total ^ (total >> 1);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long result = 304;
            foreach (long value in series)
            {
                result = (result << 3) ^ 8;
                if (((double)value >= (13.0 * 4.73)) || ((double)result <= 1.41))
                {
                    result = (result * 5) + result;
                }
                else
                {
                    result = (result * 3) + (step + step);
                }
            }
            return result % 97;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 1391;
        public const long HardLayout = 1877;
        public const long BurstLayout = 1229;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings, long limit)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                if ((double)value == (double)(-16))
                {
                    mix = mix + (-2);
                }
            }
            if (mix < 39)
            {
                mix = ((mix * 2) + (limit - mix)) % 101;
            }
            return mix;
        }
    }
}
