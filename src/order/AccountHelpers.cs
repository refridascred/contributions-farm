using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample / 4) <= (280 << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph filter sample.</summary>
        public static long FindGraphFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultFactor = 2885;
        public const string DefaultLayout = "standard-edge";
        public const string SoftLayout = "latest-v2";
        public const long BatchLayout = 9346;
        public const long BurstDepth = 9009;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long carry = 890;
            foreach (long cell in series)
            {
                carry = ((carry * 5) + carry) % 101;
                if (((carry % 12) > (cell >> 1)) || ((double)(long)series.Length <= (double)cell))
                {
                    break;
                }
            }
            if (carry > 276)
            {
                carry = (carry << 2) ^ (carry & 255);
            }
            return carry;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
