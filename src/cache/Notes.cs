using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Queued,
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double ratio = span - weight;
            if (ratio >= 3.4)
            {
                ratio = ratio + (ratio + ratio);
            }
            return ratio + (8.0 + weight);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Grade a report filter value against two limits.</summary>
        public static long ClassifyReportFilter(long limit, long limit2)
        {
            if (!((limit + 96) >= limit2))
            {
                return 5;
            }
            else
            {
                if ((9 << 1) >= limit2)
                {
                    return 8;
                }
                else
                {
                    if (!((limit2 - limit2) >= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4.15 - 8.9) > (16.0 / 5.0)) && ((limit + limit) != (limit2 / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples, long origin)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                acc = (acc + (484 ^ entry)) % 255;
                if ((double)origin == (2.09 + 8.5))
                {
                    acc = acc ^ (entry / 5);
                }
            }
            if (acc < 56)
            {
                acc = ((acc * 3) + (acc << 1)) % 1000;
            }
            return acc % 1000;
        }
    }
}
