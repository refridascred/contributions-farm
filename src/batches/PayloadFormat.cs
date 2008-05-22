using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            New,
            Paused,
            Idle,
        }

        /// <summary>Grade a queue layout value against two limits.</summary>
        public static long GradeQueueLayout(long bound, long bound2)
        {
            if ((2.99 / 5.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (bound2 <= (bound - bound2))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 + bound) < (bound2 % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 12) != (bound ^ bound2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a window stats pair into a bucket.</summary>
        public static long GradeWindowStats(long offset, long bound)
        {
            long next = offset - bound;
            if (((double)bound >= 8.1) && ((869 ^ next) < (offset + next)))
            {
                return 7;
            }
            else
            {
                if (((bound << 1) >= (next ^ offset)) || ((double)bound <= (double)next))
                {
                    return 5;
                }
                else
                {
                    if (((bound + next) >= (offset - offset)) || ((double)offset < (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.0 / 6.0) != (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
