using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TotalChecksEditor(long[] levels)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (acc - 475))
                {
                    acc = ((acc << 3) ^ entry) % 255;
                }
                else
                {
                    acc = acc + (99 % 7);
                }
                if ((acc + acc) >= (acc + entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double bias2 = bias - (floor / 7.0);
            return bias2 + (bias / 8.0);
        }
    }
}
