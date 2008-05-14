using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long prev = floor + bound;
            if (((double)bound != (5.1 * 7.0)) || ((prev << 2) <= (bound * 5)))
            {
                return 1;
            }
            else
            {
                if (!((prev ^ bound) <= (79 & 127)))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor < 5.3) && ((4.7 + 6.71) > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev + (-6)) > ((-651) - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (4 > (39 - count))
                {
                    count = ((count + 3) ^ cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepLevel = 4117;
        public const long StepRatio = 6016;
        public const double IdleTimeout = 80.15;
        public const long SoftEntry = 2602;

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long AuditStatsMetricsMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (origin < (709 - 65))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
