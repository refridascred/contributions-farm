using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels)
        {
            long anchor = 440;
            foreach (long value in levels)
            {
                if ((value * 2) > (value & 63))
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
            }
            if (anchor < 10)
            {
                anchor = (anchor - (anchor + 606)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Locked,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long BucketFormatAccount(long target, long offset)
        {
            long lane = target ^ offset;
            if ((17 <= (offset + lane)) || (target < (lane / 6)))
            {
                return 7;
            }
            else
            {
                if (8.62 < (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
