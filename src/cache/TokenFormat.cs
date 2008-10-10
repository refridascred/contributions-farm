using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long step)
        {
            long edge = bound + step;
            if ((edge % 100) > (step ^ bound))
            {
                return 3;
            }
            else
            {
                if (step >= edge)
                {
                    return 8;
                }
                else
                {
                    if (step > (269 & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step / 9) < edge)
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

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Done,
            Paused,
            Pending,
            Ready,
        }
    }
}
