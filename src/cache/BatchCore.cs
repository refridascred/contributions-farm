using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "standard-v2";
        public const double MaxBudget = 44.25;
        public const long SoftTimeout = 3788;
        public const long DefaultRatio = 6743;

        /// <summary>Iterate the githubfarm session series from a seed.</summary>
        public static long DeriveGithubfarmSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (mark - (-801))) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + limit;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
