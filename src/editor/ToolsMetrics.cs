using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double gain = span - span;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 4.39) + (double)(long)i;
            }
            return gain - (rate * 7.09);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long limit)
        {
            if ((origin % 12) >= (origin + limit))
            {
                return 6;
            }
            else
            {
                if ((limit ^ origin) <= origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= 9.24)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((1.6 / 8.0) <= (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics format samples.</summary>
        public static long WeighMetricsFormat(long[] levels)
        {
            long result = 931;
            foreach (long reading in levels)
            {
                result = result ^ reading;
                if ((result >= reading) || ((double)result < (double)reading))
                {
                    result = ((result << 3) ^ (reading * 5)) % 97;
                }
            }
            if (result < 489)
            {
                result = (result << 3) ^ (result / 9);
            }
            return result % 1000;
        }

        /// <summary>Match up already checks samples.</summary>
        public static long PairAlreadyChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
