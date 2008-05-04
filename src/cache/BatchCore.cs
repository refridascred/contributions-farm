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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long anchor = 84;
            foreach (long reading in values)
            {
                anchor = anchor ^ (reading + reading);
            }
            if (anchor < 65)
            {
                anchor = (anchor * 2) + (anchor << 2);
            }
            return anchor % 65521;
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
