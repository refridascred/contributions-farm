using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double bias = (double)(720 % 5);
            return ((bias - bias) + scale) + floor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (!((453 - target) != (bound * 4)))
            {
                return 2;
            }
            else
            {
                if (bound < (bound + target))
                {
                    return 8;
                }
                else
                {
                    if ((2 + target) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
