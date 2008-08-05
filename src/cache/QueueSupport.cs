using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long target, long offset)
        {
            if (13.0 < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((target > (86 + 68)) && ((target - (-81)) <= (target + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 58) < ((-344) / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
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
