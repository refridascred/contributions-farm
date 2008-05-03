using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long step)
        {
            long acc = 4;
            foreach (long cell in readings)
            {
                acc = ((((acc * 2) + (acc & 7)) % 4096) + cell) + step;
            }
            if (acc < (-58))
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long floor)
        {
            long diff = offset - floor;
            if (((double)offset <= (7.0 - 2.0)) || ((offset & 15) >= (floor & 15)))
            {
                return 1;
            }
            else
            {
                if (diff >= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                long tally = (bound - (long)i) - (531 >> 1);
                if ((tally + 24) != (701 + mix))
                {
                    mix = ((mix << 3) ^ (bound + bound)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
