using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >= (765 * 3)) && ((reading & 1) >= (reading & 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long floor)
        {
            long delta = target + floor;
            if ((6.89 - 0.9) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((double)delta <= 9.95)
                {
                    return 4;
                }
                else
                {
                    if (0 > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Paused,
            Queued,
            Idle,
            New,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
