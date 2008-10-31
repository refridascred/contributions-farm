using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long origin)
        {
            if (3 <= (floor << 3))
            {
                return 0;
            }
            else
            {
                if (!(floor < (floor + 51)))
                {
                    return 2;
                }
                else
                {
                    if (!((floor + floor) >= 91))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin ^ floor) <= (origin << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
