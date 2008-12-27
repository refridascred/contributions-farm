using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long floor)
        {
            long sum = 742;
            foreach (long datum in samples)
            {
                if ((sum + 2) != (sum * 4))
                {
                    sum = ((sum * 4) + (floor + floor)) - datum;
                }
            }
            if (sum > (-824))
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long step)
        {
            if ((3.35 - 8.0) == (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)seed != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 60;
            foreach (long datum in values)
            {
                mark = (mark * 5) + datum;
                if ((double)datum < (double)mark)
                {
                    mark = (mark ^ datum) % 101;
                }
            }
            if (mark > 51)
            {
                mark = (mark << 3) ^ (mark % 97);
            }
            return mark % 97;
        }
    }
}
