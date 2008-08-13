using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long offset)
        {
            if (!((double)step < (2.5 + 1.7)))
            {
                return 7;
            }
            else
            {
                if ((step + step) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((step ^ 200) > (165 >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardCount = 80.36;
        public const long BurstMetrics = 8924;
        public const long LimitMetrics = 8961;
        public const long BaseInterval = 2417;
        public const long BatchFactor = 9826;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
