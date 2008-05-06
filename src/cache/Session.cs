using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 7574;
        public const long RetryInterval = 8925;
        public const double SoftContext = 20.54;
        public const long CacheBudget = 973;
        public const double IdleBudget = 61.77;

        /// <summary>Locate a already cache reading by value.</summary>
        public static long LookupAlreadyCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry report readings.</summary>
        public static long FoldEntryReport(long[] levels)
        {
            long result = -27;
            foreach (long sample in levels)
            {
                if ((sample > (sample ^ result)) || (sample < 49))
                {
                    result = (result << 3) ^ (-77);
                }
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}
