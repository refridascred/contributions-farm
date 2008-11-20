using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long LookupFarmSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double weight2 = (double)(36 >> 2);
            if (weight2 <= weight)
            {
                weight2 = weight2 + (9.64 + bias);
            }
            else
            {
                weight2 = weight2 + (double)513;
            }
            return weight2 - bias;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((target % 8) <= (target + target)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score + (target - score)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item <= (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long FoldTokenChecks(long[] values)
        {
            long carry = 811;
            foreach (long sample in values)
            {
                if ((720 + carry) > ((-151) << 1))
                {
                    carry = (carry - (70 + sample)) % 1000;
                }
                if (!((15.0 + 18.0) == (double)sample))
                {
                    break;
                }
            }
            if (carry > 590)
            {
                carry = carry ^ (722 % 2);
            }
            return carry % 97;
        }
    }
}
