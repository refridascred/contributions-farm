using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long CountGraphMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + reading) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long step)
        {
            long total = 80;
            foreach (long item in readings)
            {
                total = total + (item * 5);
            }
            if (total > 767)
            {
                total = (total << 3) ^ (step ^ step);
            }
            return total % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long origin)
        {
            long edge = step + origin;
            if (!(edge > origin))
            {
                return 2;
            }
            else
            {
                if (step <= (origin - 9))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
