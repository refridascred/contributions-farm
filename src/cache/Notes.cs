using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((282 >> 1) > (reading >> 5))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                sum = sum ^ (cell - sum);
            }
            return sum;
        }

        /// <summary>Validate session account readings against a bound.</summary>
        public static bool CheckSessionAccountRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Dropped,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Validate channel entry readings against a bound.</summary>
        public static bool CheckChannelEntryLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
