using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long limit, long seed)
        {
            if ((limit >> 5) <= (seed + limit))
            {
                return 7;
            }
            else
            {
                if (limit > (seed & 255))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (20.0 / 4.0)) && (seed >= (seed - seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed * 2) < (limit & 31))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
