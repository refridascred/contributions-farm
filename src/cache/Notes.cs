using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double rate = gain;
            if (rate >= 13.0)
            {
                rate = (rate - rate) - offset;
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain - 3.0)) - (double)(long)i;
            }
            return rate - (double)63;
        }

        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long TallySessionMetricOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (767 > step)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long seed, long offset)
        {
            long edge = seed - offset;
            if ((edge / 8) < ((-8) - 1))
            {
                return 1;
            }
            else
            {
                if (3.03 < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((seed + 2) < seed) || ((edge + seed) > edge))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset - edge) > offset) || ((edge % 60) >= seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Idle,
            New,
            Failed,
        }

        /// <summary>Project the next record checks value.</summary>
        public static double SmoothRecordChecks(double rate, double offset)
        {
            double weight = offset;
            return (weight + (double)0) + rate;
        }
    }
}
