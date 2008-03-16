using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (4 > (tally - cell))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long offset, long target)
        {
            long cur = offset ^ target;
            if ((7 % 64) > (target ^ offset))
            {
                return 8;
            }
            else
            {
                if (((double)target > (6.52 / 3.0)) && ((double)target < (7.37 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    if ((cur - cur) >= cur)
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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double load = bias + (bias / 8.0);
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 2.0) - (double)(long)i) + ratio;
            }
            return load - (double)7;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((5.77 - 13.0) < (double)count) || ((count ^ count) < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
