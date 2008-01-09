using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Failed,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long target)
        {
            long offset = floor - target;
            if (!(840 <= (offset & 7)))
            {
                return 6;
            }
            else
            {
                if ((floor - 385) != (offset & 15))
                {
                    return 3;
                }
                else
                {
                    if ((1 ^ floor) > (floor % 97))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target >> 3) < offset) || ((double)offset < 20.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
