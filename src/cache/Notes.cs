using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a counter support counter forward.</summary>
        public static long RollCounterSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - 26) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long floor2)
        {
            if (floor < (floor & 1))
            {
                return 2;
            }
            else
            {
                if ((floor2 << 3) < 216)
                {
                    return 8;
                }
                else
                {
                    if ((floor2 ^ floor2) <= (floor & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double mean = bias + (bias - bias);
            if (mean <= (span * 5.79))
            {
                mean = mean + (double)1;
            }
            else
            {
                mean = mean - (bias / 8.0);
            }
            return mean - (2.0 + 13.0);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - item) < (matches >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels)
        {
            long mix = 28;
            foreach (long reading in levels)
            {
                mix = ((mix * 5) + (reading + mix)) % 65521;
            }
            return mix;
        }
    }
}
