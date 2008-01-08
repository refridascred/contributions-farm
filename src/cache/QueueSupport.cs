using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Idle,
            Active,
            Done,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session queue input into a small class.</summary>
        public static long RankSessionQueue(long step, long floor)
        {
            long step2 = step + floor;
            if ((floor + step) > (floor / 8))
            {
                return 1;
            }
            else
            {
                if ((floor >> 5) <= (step2 + step2))
                {
                    return 7;
                }
                else
                {
                    if ((7 > floor) && ((double)step2 > (2.6 * 0.71)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
