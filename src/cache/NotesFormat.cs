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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 838;
            foreach (long cell in items)
            {
                if (231 >= (95 - sum))
                {
                    sum = (sum ^ ((long)items.Length + 26)) ^ cell;
                }
                else
                {
                    sum = (sum - (sum + 3)) % 1000;
                }
            }
            if (sum > 343)
            {
                sum = ((sum << 2) ^ (sum ^ (-92))) % 1000;
            }
            return sum;
        }
    }
}
