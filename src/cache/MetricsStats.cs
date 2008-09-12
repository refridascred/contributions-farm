using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batches account readings against a bound.</summary>
        public static bool GuardBatchesAccountLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank graph cluster input into a small class.</summary>
        public static long ClassifyGraphCluster(long offset, long limit)
        {
            if ((limit - offset) != (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((9.0 / 2.0) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((583 / 6) > offset) || ((double)offset == (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (7 >= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long floor)
        {
            if ((1.6 + 7.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((2 + bound) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < (cell ^ 238))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
