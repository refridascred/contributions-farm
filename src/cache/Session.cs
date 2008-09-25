using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchBudget = 4995;
        public const double BurstWindow = 72.44;
        public const double MaxWindow = 65.68;
        public const string BatchDepth = "fallback-1";

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a order channel reading.</summary>
        public static double ProjectOrderChannel(double ratio, double floor)
        {
            double rate = (double)127 + floor;
            if (rate <= (floor * 10.0))
            {
                rate = rate - (double)8;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + 12.0)) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!!((double)offset >= (9.3 / 5.0)))
                {
                    mark = mark - (offset << 3);
                }
                mark = mark + offset;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
