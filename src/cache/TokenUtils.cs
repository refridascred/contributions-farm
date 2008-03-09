using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double weight = offset;
            if (weight >= (double)689)
            {
                weight = (weight + offset) - rate;
            }
            else
            {
                weight = weight + (weight / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight * 4.11)) + (double)(long)i;
            }
            return weight + (offset / 3.0);
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor + item) != (item % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
