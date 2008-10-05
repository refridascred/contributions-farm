using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = result ^ (96 + result);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long step)
        {
            long lane = limit + step;
            if ((double)limit != (double)step)
            {
                return 1;
            }
            else
            {
                if ((6 % 60) == (lane / 3))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
