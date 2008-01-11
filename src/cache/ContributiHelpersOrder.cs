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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
