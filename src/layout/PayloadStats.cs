using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings)
        {
            long acc = 110;
            foreach (long sample in readings)
            {
                acc = (acc - sample) % 97;
                if (((acc * 2) == (acc + acc)) && (sample > (sample << 3)))
                {
                    acc = (acc - (acc & 1)) % 101;
                }
            }
            if (acc > (-849))
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a booking sample.</summary>
        public static long SeekBookingIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry cluster reading by value.</summary>
        public static long SeekEntryClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
