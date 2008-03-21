using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ (step ^ 8)) % 101;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if ((((-36) / 3) >= (offset - offset)) || ((double)limit <= (6.3 / 2.0)))
            {
                return 4;
            }
            else
            {
                if ((offset * 2) != ((-45) + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 12) >= 98)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] levels)
        {
            long state = 787;
            foreach (long item in levels)
            {
                state = (state ^ (item + state)) % 101;
            }
            if (state < 50)
            {
                state = (state + (47 / 9)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Idle,
            Dropped,
            Queued,
        }
    }
}
