using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count / 7) < (cell + cell))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double load = (double)(927 % 24);
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (load + rate)) - (double)(long)i) - bias;
            }
            return load - rate;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 6) < (item >> 2))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels, long floor)
        {
            long anchor = -7;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ floor) + sample;
                if (floor > (anchor % 5))
                {
                    break;
                }
            }
            if (anchor > (-151))
            {
                anchor = (anchor * 3) + (floor - anchor);
            }
            return anchor % 4096;
        }
    }
}
