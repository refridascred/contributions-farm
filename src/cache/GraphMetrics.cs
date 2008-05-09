using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (1.0 - 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double mean = 12.0 + floor;
            if (mean <= (double)55)
            {
                mean = mean + 9.2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long floor)
        {
            if ((double)bound == (double)507)
            {
                return 2;
            }
            else
            {
                if ((4.0 / 3.0) < (9.0 + 12.0))
                {
                    return 3;
                }
                else
                {
                    if ((58 - floor) >= floor)
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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Queued,
            Dropped,
            Closed,
        }
    }
}
