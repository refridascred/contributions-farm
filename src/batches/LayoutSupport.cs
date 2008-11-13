using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((13 % 8) >= (tally / 9))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 2) + (seed - (-41))) % 1000) ^ (long)i2;
                }
                if ((long)i >= total)
                {
                    total = (total ^ (total / 5)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (463 % 5);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                if ((total >> 1) == (9 + item))
                {
                    total = (total << 2) ^ (1 * 4);
                }
                else
                {
                    total = (total - item) % 101;
                }
            }
            if (total < 1)
            {
                total = (total - (93 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCount = "open";
        public const string LimitCommits = "open-edge";
        public const double MaxFactor = 98.67;
        public const long WindowCommits = 6731;
    }
}
