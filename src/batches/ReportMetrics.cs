using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank batches profile input into a small class.</summary>
        public static long ClassifyBatchesProfile(long origin, long step)
        {
            if ((double)origin <= (5.0 + 4.9))
            {
                return 3;
            }
            else
            {
                if ((origin + step) > step)
                {
                    return 5;
                }
                else
                {
                    if ((3 + step) <= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 1) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long sum = 1;
            foreach (long cell in readings)
            {
                sum = ((sum - sum) % 4096) ^ cell;
                if ((target << 1) > sum)
                {
                    break;
                }
            }
            if (sum > 840)
            {
                sum = (sum - (89 + 3)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Ready,
            Paused,
        }
    }
}
