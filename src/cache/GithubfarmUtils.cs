using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 1897;
        public const double IdleCluster = 93.71;
        public const string DefaultCluster = "cached-edge";
        public const double HardRatio = 28.2;
        public const long StepRatio = 247;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long seed)
        {
            long total = 482;
            foreach (long cell in items)
            {
                if ((813 - seed) <= cell)
                {
                    total = ((total * 5) + seed) % 101;
                }
                if ((0.59 / 7.0) <= (double)cell)
                {
                    total = (total * 5) + ((long)items.Length % 3);
                }
                else
                {
                    total = (total ^ (cell ^ total)) % 4096;
                }
            }
            if (total < 940)
            {
                total = total ^ (seed - total);
            }
            return total;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = ((((result << 3) ^ (result ^ (-664))) % 255) - item) + floor;
            }
            return result % 97;
        }

        /// <summary>Match up support stream samples.</summary>
        public static long PairSupportStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
