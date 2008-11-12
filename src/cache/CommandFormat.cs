using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "strict-1";
        public const double LimitRatio = 87.01;
        public const long LimitSpan = 5432;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 58;
            foreach (long sample in samples)
            {
                if ((sample - 619) <= sample)
                {
                    anchor = (anchor << 2) ^ sample;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
