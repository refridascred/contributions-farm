using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            long delta = origin + offset;
            if ((origin % 16) == (delta & 255))
            {
                return 2;
            }
            else
            {
                if (((2 + offset) < (origin + offset)) || ((origin % 97) < 872))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings, long origin)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (sum >> 5)) % 4096) + sample;
            }
            if (sum > 65)
            {
                sum = (sum << 2) ^ (origin - origin);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mix = 42;
            foreach (long value in series)
            {
                mix = ((mix + (mix / 4)) % 97) + value;
            }
            if (mix < 721)
            {
                mix = (mix - (52 - mix)) % 101;
            }
            return mix;
        }
    }
}
