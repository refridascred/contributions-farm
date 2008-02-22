using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double mean = rate + rate;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - (floor / 5.0);
        }

        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long RollGraphOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                long edge = (acc - offset) - offset;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ (edge % 7)) % 101) - (long)i2;
                }
                acc = (acc ^ ((long)i + offset)) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((61 <= (entry + count)) || ((count << 3) >= (count % 64))) && ((count >> 5) > (entry + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
