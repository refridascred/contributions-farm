using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= (value ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long step)
        {
            if ((limit % 5) != (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((step - 593) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((limit + step) <= (step + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit payload notes readings against a rule.</summary>
        public static long CountPayloadNotesOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((limit % 64) <= (hits & 7))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a route channel figure with a bias.</summary>
        public static double ProjectRouteChannel(double ratio, double floor)
        {
            double ratio2 = (double)((-78) + 701);
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            return ratio2 + (ratio2 / 2.0);
        }
    }
}
