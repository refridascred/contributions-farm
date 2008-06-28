using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long FoldContributiSchema(long[] levels, long step)
        {
            long total = 870;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = total ^ ((long)i + step);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + (total % 7)) + (long)i2;
                    total = (total + (total ^ 8)) % 255;
                }
                if (!((double)reading <= 2.87))
                {
                    total = total ^ reading;
                }
            }
            if (total < 8)
            {
                total = (total ^ (34 >> 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Adjust a tools order reading.</summary>
        public static double ScaleToolsOrder(double weight, double bias)
        {
            double load = bias;
            if (load <= (0.8 * 1.3))
            {
                load = (load + bias) + weight;
            }
            return load + (7.7 * 15.0);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long step)
        {
            if (seed > (step & 255))
            {
                return 2;
            }
            else
            {
                if ((seed * 2) != (step ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed >= (12.0 / 6.0)) && ((step + seed) != (step + 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell + seed) <= (690 - seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
