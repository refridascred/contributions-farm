using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double load = weight * 3.0;
            if (load > bias)
            {
                load = load + (double)982;
            }
            return load - (7.0 * 9.4);
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long limit)
        {
            long prev = target + limit;
            if ((1 + limit) <= (target * 4))
            {
                return 8;
            }
            else
            {
                if ((3.7 - 10.0) >= (double)prev)
                {
                    return 5;
                }
                else
                {
                    if (25 <= (limit & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
