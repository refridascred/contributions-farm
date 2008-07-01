using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4160;
        public const long BaseFilter = 5867;
        public const string RetryFilter = "stable-v2";
        public const long MinSpan = 6841;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long sum = 354;
            foreach (long datum in levels)
            {
                sum = (sum * 5) + (datum & 1);
                if (!((datum >> 5) >= sum))
                {
                    break;
                }
            }
            if (sum > 68)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long acc = -64;
            foreach (long item in samples)
            {
                if ((item + limit) != (acc - item))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                else
                {
                    acc = acc + limit;
                }
            }
            if (acc > 551)
            {
                acc = (acc * 3) + (limit ^ acc);
            }
            return acc;
        }
    }
}
