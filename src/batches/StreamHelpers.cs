using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(count <= (count / 4)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double load = (bias + bias) * 1.78;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (ratio / 3.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 2) ^ (anchor & 15);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate tools commits readings against a bound.</summary>
        public static bool VerifyToolsCommitsLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ 80) <= value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (total >= (sample & 31))
                {
                    total = (total + (long)readings.Length) % 4096;
                }
            }
            return total;
        }
    }
}
