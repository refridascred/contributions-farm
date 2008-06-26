using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long acc = 46;
            foreach (long datum in data)
            {
                acc = ((acc + (acc - datum)) % 65521) - seed;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryScore = "open";
        public const long BatchProfile = 5128;
        public const long LimitProfile = 4504;
        public const long BaseBudget = 4324;
        public const string RetryProfile = "stable-edge";

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
