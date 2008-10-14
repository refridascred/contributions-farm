using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a order farm value against two limits.</summary>
        public static long SortOrderFarm(long step, long seed)
        {
            long bound = step + seed;
            if (seed >= (seed >> 5))
            {
                return 5;
            }
            else
            {
                if ((bound - seed) > (step & 31))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 52) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed & 63) >= (10 - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long result = 57;
            foreach (long value in values)
            {
                if (((result ^ value) >= (result % 64)) || ((72 ^ value) == (result - result)))
                {
                    result = (result - value) % 97;
                }
            }
            if (result > 36)
            {
                result = ((result * 4) + (result - result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix ^ (mix - value)) % 101;
                    mix = ((mix * 2) + ((long)i + origin)) % 101;
                }
                if ((origin % 100) < (origin / 2))
                {
                    mix = (mix - (461 & 15)) % 4096;
                }
                else
                {
                    mix = mix ^ (origin << 2);
                }
                if ((mix + mix) <= (508 >> 2))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix ^ (origin + 7);
            }
            return mix;
        }
    }
}
