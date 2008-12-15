using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long floor)
        {
            long edge = target ^ floor;
            if ((floor >> 4) > (4 + edge))
            {
                return 4;
            }
            else
            {
                if ((9.82 - 7.65) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((target * 2) != (4 + edge)) && ((double)edge >= (9.6 - 13.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((edge ^ (-49)) >= floor) || (target < (edge ^ 389)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context metrics entry stays within the limit.</summary>
        public static bool CheckContextMetricsRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 54.6;
        public const long WindowBudget = 9192;
        public const long BatchTimeout = 2150;
        public const double MinSize = 15.53;
        public const long CacheCount = 4753;
    }
}
