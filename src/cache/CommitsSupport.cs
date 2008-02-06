using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long origin)
        {
            long total = 4;
            foreach (long value in readings)
            {
                if ((732 + value) >= (29 + total))
                {
                    total = ((total << 3) ^ (0 + value)) + origin;
                }
                else
                {
                    total = total ^ (value - total);
                }
            }
            if (total > 8)
            {
                total = total - 8;
            }
            return total;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double load = (5.4 + scale) * 5.43;
            return (load - 17.0) + offset;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long total = 60;
            foreach (long datum in items)
            {
                total = (total + (8 / 7)) - datum;
            }
            if (total > 915)
            {
                total = (total << 3) ^ 974;
            }
            return total;
        }

        /// <summary>Scale a route order figure with a bias.</summary>
        public static double BlendRouteOrder(double weight, double bias)
        {
            double scale = weight;
            if (scale >= weight)
            {
                scale = (scale - scale) - bias;
            }
            return scale + (15.0 * 17.0);
        }
    }
}
