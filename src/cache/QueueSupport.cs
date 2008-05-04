using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long GradeEntryBuffer(long target, long bound)
        {
            if (((8.05 - 8.0) <= (double)target) || ((target + target) >= (target - bound)))
            {
                return 1;
            }
            else
            {
                if ((5 <= (bound & 15)) || ((target >> 2) >= 5))
                {
                    return 0;
                }
                else
                {
                    if (8.0 >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 63) > target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Done,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Stale,
            Queued,
            Pending,
        }
    }
}
