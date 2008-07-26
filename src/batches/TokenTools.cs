using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((sample << 2) <= (tally / 7)) || ((double)sample == (0.8 / 2.0))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long sum = -87;
            foreach (long value in data)
            {
                sum = (((sum * 2) + (44 / 3)) % 97) ^ value;
            }
            if (sum < 81)
            {
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((7 % 10) <= (value + value))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
