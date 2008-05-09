using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up stats editor samples.</summary>
        public static long PairStatsEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long offset)
        {
            long next = limit - offset;
            if ((next + 100) != (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((113 + offset) >= next)
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 4.8) == (double)limit)
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

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double mean = scale;
            return mean - (offset / 2.0);
        }

        /// <summary>Check that every filter cluster entry stays within the limit.</summary>
        public static bool ValidateFilterClusterRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double scale = 4.33;
            if (scale > span)
            {
                scale = (scale - (double)965) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - scale)) + (double)(long)i;
            }
            return scale - (scale - span);
        }
    }
}
