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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
