using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double bias = 0.7 * 6.85;
            return ((bias + (7.75 - 9.4)) + gain) + offset;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1616;
        public const double BatchProfile = 44.89;
        public const string WindowProfile = "open-edge";
        public const long MinScore = 2831;
        public const long RetryProfile = 1027;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long acc = 786;
            foreach (long reading in readings)
            {
                if ((double)acc > (double)reading)
                {
                    acc = (acc * 5) + ((-1) & 15);
                }
                acc = acc ^ reading;
            }
            return acc % 97;
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long ClassifyFilterWindow(long offset, long offset2)
        {
            long slot = offset - offset2;
            if ((double)83 != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)slot != (8.0 + 8.6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
