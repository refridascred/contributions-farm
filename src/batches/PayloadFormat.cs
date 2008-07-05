using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if ((6.0 - 3.4) <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((2.24 / 7.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long target)
        {
            long sum = 520;
            foreach (long sample in levels)
            {
                sum = sum ^ target;
                if ((target >> 4) == (sum ^ sample))
                {
                    break;
                }
            }
            if (sum > 79)
            {
                sum = sum - (target >> 4);
            }
            return sum % 4096;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long origin)
        {
            long score = 0;
            foreach (long cell in values)
            {
                score = (score ^ origin) ^ cell;
                score = (score + origin) % 65521;
            }
            if (score > 23)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }
    }
}
