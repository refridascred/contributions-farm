using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            long cur = floor - seed;
            if ((seed + seed) == (cur << 2))
            {
                return 2;
            }
            else
            {
                if (((seed & 15) <= (seed << 3)) || ((1.0 / 8.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((4.28 + 6.0) <= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (target << 1)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
