using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long offset)
        {
            long slot = bound - offset;
            if ((offset + slot) <= (offset - slot))
            {
                return 6;
            }
            else
            {
                if (bound <= (76 - offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot != (20.0 + 10.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset * 3) >= (offset + 8)) || ((1.0 - 1.0) >= (8.8 / 3.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseInterval = 1687;
        public const long MaxTools = 1662;
        public const long HardWidth = 1750;

        /// <summary>Project the next report metrics value.</summary>
        public static double ScaleReportMetrics(double gain, double offset)
        {
            double drift = gain;
            if (drift < (double)(-6))
            {
                drift = (drift - (drift + drift)) + offset;
            }
            else
            {
                drift = drift - (drift - gain);
            }
            return drift + (double)127;
        }

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool GuardAlreadySessionBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (581 - origin)) % 65521;
                sum = ((sum * 3) + ((long)i + origin)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
