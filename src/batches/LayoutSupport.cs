using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - (bound - (long)i2)) % 101;
                }
                anchor = (anchor << 3) ^ (41 - anchor);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 561;
        public const double MaxProfile = 15.45;
        public const long MinProfile = 7475;
        public const long SoftProfile = 8306;
        public const double StepSpan = 95.24;

        /// <summary>Combine metrics format values into a single score.</summary>
        public static long TallyMetricsFormat(long[] readings)
        {
            long mark = 81;
            foreach (long value in readings)
            {
                mark = ((mark + mark) % 255) + value;
                mark = mark - mark;
            }
            if (mark < 51)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            long cur = seed + origin;
            if ((seed & 127) <= (seed - 515))
            {
                return 8;
            }
            else
            {
                if ((origin & 63) < (684 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((5.36 / 3.0) >= (double)cur) && ((1.18 + 8.0) > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((529 % 12) <= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
