using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((0.6 / 6.0) < (double)cell)
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                if ((cell + sum) >= sum)
                {
                    sum = (sum * 5) + (71 % 10);
                }
                else
                {
                    sum = (sum << 3) ^ (sum % 2);
                }
                sum = (sum - (long)samples.Length) % 97;
            }
            if (sum < 898)
            {
                sum = (sum << 2) ^ (925 ^ sum);
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSize = 5775;
        public const string StepLevel = "latest-v2";
        public const long BatchFactor = 9765;
        public const double SoftCache = 84.56;
        public const string BaseWidth = "standard-v2";

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
