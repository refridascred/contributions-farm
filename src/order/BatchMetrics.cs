using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools support pair into a bucket.</summary>
        public static long BucketToolsSupport(long origin, long offset)
        {
            if (offset > (928 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset & 7) < origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - 59) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin * 2) <= (offset << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long diff = seed + step;
            if ((96 - diff) <= 8)
            {
                return 8;
            }
            else
            {
                if ((2.27 + 8.1) >= (double)diff)
                {
                    return 2;
                }
                else
                {
                    if ((step & 7) > ((-83) ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 8) <= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long target)
        {
            long carry = 361;
            foreach (long cell in values)
            {
                if ((target >> 3) != (target + cell))
                {
                    carry = ((carry * 5) + (cell * 5)) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
