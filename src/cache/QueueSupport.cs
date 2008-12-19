using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if ((bound - offset) > offset)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) == (offset * 2))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 / 6.0) != (double)bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Validate checks profile readings against a bound.</summary>
        public static bool GuardChecksProfileBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
