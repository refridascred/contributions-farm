using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long offset)
        {
            long gap = step - offset;
            if (((gap >> 1) <= 91) && ((5.3 + 12.0) > (double)offset))
            {
                return 2;
            }
            else
            {
                if (((0 + step) <= (177 - offset)) && (step < (3 + 3)))
                {
                    return 1;
                }
                else
                {
                    if ((gap + gap) == (gap - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowSize = 8838;
        public const long SoftDepth = 2451;
        public const string IdleStats = "alpha-v2";

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double mean = 2.5;
            if (mean <= (mean + mean))
            {
                mean = ((mean + (mean * 2.56)) - ratio) - span;
            }
            else
            {
                mean = mean + (mean * 7.5);
            }
            return mean - (double)689;
        }
    }
}
