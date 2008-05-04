using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long limit2)
        {
            if ((limit << 1) <= (limit2 + limit2))
            {
                return 6;
            }
            else
            {
                if ((limit * 3) < limit2)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 97) <= (4 + limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit2) >= (limit2 - limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
