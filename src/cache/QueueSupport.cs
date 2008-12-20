using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long lane = target - seed;
            if (!((target ^ target) >= (seed << 2)))
            {
                return 8;
            }
            else
            {
                if ((lane * 2) == (lane + 44))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool CheckEntryAccountRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                anchor = (anchor - seed) + cell;
                anchor = anchor ^ 4;
            }
            return anchor;
        }
    }
}
