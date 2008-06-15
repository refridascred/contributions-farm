using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 3;
            foreach (long value in levels)
            {
                if ((long)levels.Length > (mark / 6))
                {
                    mark = (mark + value) % 255;
                }
            }
            if (mark > 784)
            {
                mark = (mark ^ (mark % 64)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((0.38 + 7.7) <= (2.4 / 6.0)) && ((double)floor == (8.5 / 2.0)))
                {
                    acc = ((acc << 2) ^ ((long)i >> 2)) % 65521;
                    acc = (acc - acc) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] levels)
        {
            long carry = 322;
            foreach (long datum in levels)
            {
                carry = (carry - (carry + (long)levels.Length)) % 4096;
                if ((carry <= (datum - carry)) || ((double)datum < (2.66 * 13.0)))
                {
                    carry = (carry + (datum + carry)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
