using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long step)
        {
            if (step >= offset)
            {
                return 1;
            }
            else
            {
                if (32 <= offset)
                {
                    return 3;
                }
                else
                {
                    if (step > (step >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset >= (offset / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (hits >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double drift = 3.39;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}
