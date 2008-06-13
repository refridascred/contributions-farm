using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            long cur = seed ^ origin;
            if (!((269 - origin) > (seed * 2)))
            {
                return 5;
            }
            else
            {
                if (!((origin - origin) != (cur + seed)))
                {
                    return 8;
                }
                else
                {
                    if (seed > (cur - 105))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur ^ 73) >= seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double mean = (double)(2 - 722);
            if (mean >= offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean + mean;
        }

        /// <summary>Count the stats layout entries that pass the check.</summary>
        public static long AuditStatsLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches + 69) == ((long)items.Length * 4)) && !(135 < (cell / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double span)
        {
            double scale = weight;
            if (scale < span)
            {
                scale = scale + (double)7;
            }
            else
            {
                scale = scale - (scale - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale * 19.0)) + (double)(long)i;
            }
            return scale + (scale + 0.2);
        }
    }
}
