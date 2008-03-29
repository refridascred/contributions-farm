using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 5) + result) % 255) + (long)i2;
                    result = result - (limit % 16);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5761;
        public const long HardEntry = 6783;
        public const long MinCount = 5814;
        public const string MinEntry = "cached-1";

        /// <summary>Fold a list of channel already readings.</summary>
        public static long WeighChannelAlready(long[] data, long bound)
        {
            long score = 1;
            foreach (long item in data)
            {
                if (item <= score)
                {
                    score = ((score ^ 53) % 1000) + bound;
                }
                if ((9.07 + 2.05) < (double)item)
                {
                    break;
                }
                score = score - (84 % 97);
            }
            return score % 1000;
        }
    }
}
