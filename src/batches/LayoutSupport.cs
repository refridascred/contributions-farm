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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading + reading) != (4 & 127)) && !((double)matches > (double)(long)samples.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long target, long origin)
        {
            if (((target >> 4) != (origin * 3)) || (((-268) - target) <= (origin + origin)))
            {
                return 6;
            }
            else
            {
                if (origin < (77 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
