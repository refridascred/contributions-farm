using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Rank report session input into a small class.</summary>
        public static long SortReportSession(long limit, long step)
        {
            if (((22 + limit) <= limit) && ((limit - limit) > (8 ^ limit)))
            {
                return 8;
            }
            else
            {
                if (limit > (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if (!((limit - 7) < step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Locked,
            Stale,
            Synced,
        }
    }
}
