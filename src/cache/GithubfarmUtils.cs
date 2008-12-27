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

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 5590;
        public const long SoftRatio = 6183;
        public const long SoftQueue = 7885;
        public const long MaxQueue = 8876;
        public const long DefaultQueue = 4113;

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
