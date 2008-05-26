using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long RollFarmTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (sum - origin)) % 4096;
                sum = (sum * 2) + ((long)i ^ sum);
                if (sum > (origin + 612))
                {
                    sum = (sum * 5) + (sum * 5);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ (origin >> 3);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell < (8.9 + 4.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
