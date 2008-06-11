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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((-8) + value) != (330 << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
