using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long origin)
        {
            if ((origin - origin) >= (target % 8))
            {
                return 3;
            }
            else
            {
                if (origin < (target + target))
                {
                    return 6;
                }
                else
                {
                    if (9.51 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin < (134 * 3)) && ((origin + origin) <= origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long step)
        {
            long diff = bound - step;
            if (!(step >= (bound << 3)))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= diff) || ((-453) > (step * 2)))
                {
                    return 7;
                }
                else
                {
                    if (diff >= (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "strict-v2";
        public const long BaseScore = 8798;
        public const long RetryRatio = 7184;
        public const double IdleSchema = 41.86;

        /// <summary>Adjust a route contributi reading.</summary>
        public static double SmoothRouteContributi(double ratio, double offset)
        {
            double weight = (ratio * 7.0) - (double)26;
            if (weight > (4.0 - 8.9))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (offset + 1.21)) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
