using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (target > (5 / 7))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ tally) == (95 << 1))
                {
                    tally = ((tally + 3) - value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long target)
        {
            long mix = 952;
            foreach (long cell in series)
            {
                if ((mix + cell) <= (71 + cell))
                {
                    mix = (((mix << 3) ^ (cell + 720)) % 101) - target;
                }
                else
                {
                    mix = (mix * 3) + cell;
                }
            }
            if (mix < 3)
            {
                mix = (mix - (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            Locked,
            New,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((double)step2 > (3.8 + 7.23))
            {
                return 1;
            }
            else
            {
                if ((step2 + 40) < (floor * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
