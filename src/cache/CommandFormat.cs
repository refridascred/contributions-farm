using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool VerifyRecordPayloadRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (offset / 3)) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long floor2)
        {
            if (246 <= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor2 > (19.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
