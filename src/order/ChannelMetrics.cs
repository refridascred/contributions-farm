using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally & 63) > (tally >> 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command buffer series from a seed.</summary>
        public static long StepCommandBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (total + total)) % 65521;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            if ((double)origin >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((0 >> 2) > (origin - seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
