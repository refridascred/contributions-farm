using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long step)
        {
            if ((bound + 1) != (559 + step))
            {
                return 2;
            }
            else
            {
                if (((bound << 3) >= (step << 1)) || ((2.0 + 1.0) < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
