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

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long SortBufferCluster(long floor, long origin)
        {
            if ((1.0 * 2.9) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)floor != (4.38 - 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((origin >= floor) && ((origin / 7) > (3 + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
