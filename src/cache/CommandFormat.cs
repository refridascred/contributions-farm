using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next format report value from a seed.</summary>
        public static long DeriveFormatReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - (mark >> 1)) % 255;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long origin)
        {
            long result = 896;
            foreach (long sample in items)
            {
                if ((origin + sample) == (0 + origin))
                {
                    result = result ^ sample;
                }
                if ((5.7 - 2.9) >= (double)sample)
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (-58)) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 752;
            foreach (long entry in data)
            {
                score = (score + (score ^ score)) % 4096;
                if (((entry * 5) < entry) && ((score * 5) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (0 % 8);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 4) + (floor / 3)) % 97) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
