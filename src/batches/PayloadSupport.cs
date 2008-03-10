using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a buffer format value against two limits.</summary>
        public static long RankBufferFormat(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target == (10.0 - 8.2))
            {
                return 1;
            }
            else
            {
                if ((span << 2) < (span + 728))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) > (floor + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Locked,
            Paused,
            Closed,
        }
    }
}
