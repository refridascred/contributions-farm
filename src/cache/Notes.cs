using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double weight = bias - (offset - bias);
            if (weight >= (bias + weight))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight + (7.0 + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight - weight)) + (double)(long)i;
            }
            return weight + (offset + offset);
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long CountToolsGithubfarmMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)step < (double)61)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ floor;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor - ((long)i2 - anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 3) ^ (floor - (long)i)) % 4096;
                carry = ((carry << 2) ^ 742) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 3) ^ 237) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
