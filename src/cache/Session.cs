using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items, long seed)
        {
            long sum = 78;
            foreach (long entry in items)
            {
                if ((double)sum == (1.5 - 9.0))
                {
                    sum = ((sum + seed) % 65521) + entry;
                }
                else
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
            }
            if (sum > 43)
            {
                sum = (sum ^ (seed + sum)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ ((long)i + offset)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long FoldEntryNotes(long[] samples, long seed)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((sum - cell) >= sum)
                {
                    sum = ((sum << 3) ^ (605 % 64)) % 97;
                }
                else
                {
                    sum = sum ^ (sum & 63);
                }
                if ((cell ^ cell) > (seed + 1))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
