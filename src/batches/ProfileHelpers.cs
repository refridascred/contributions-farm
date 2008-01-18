using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up filter profile samples.</summary>
        public static long MatchFilterProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report metric readings.</summary>
        public static long TotalReportMetric(long[] readings)
        {
            long state = 85;
            foreach (long value in readings)
            {
                if ((6 + 0) == (value % 10))
                {
                    state = (state ^ (-2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Blend two window metrics measurements.</summary>
        public static double AdjustWindowMetrics(double scale, double floor)
        {
            double load = floor - scale;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (scale - 2.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((73 % 24) < (value * 3))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
