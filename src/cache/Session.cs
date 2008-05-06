using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 95.53;
        public const string MinGithubfarm = "cached";
        public const long RetryInterval = 9143;
        public const string DefaultGithubfarm = "standard-1";

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
