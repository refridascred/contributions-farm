using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long bound)
        {
            if ((3.27 / 2.0) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed % 12) <= 572)
                {
                    return 6;
                }
                else
                {
                    if ((7.0 - 17.0) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many profile queue samples are out of range.</summary>
        public static long TallyProfileQueueOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 - floor) > floor)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
