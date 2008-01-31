using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double load = (scale / 3.0) * 2.0;
            if (load <= load)
            {
                load = (load - 3.35) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)18;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] data)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                if ((4 - 0) != (anchor / 2))
                {
                    anchor = (((anchor << 3) ^ anchor) % 1000) - item;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor / 7);
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftFactor = 70.99;
        public const long MinScore = 8130;
        public const string BatchCount = "latest-v2";
        public const string WindowGithubfarm = "latest-edge";

        /// <summary>Look up the position of a command entry sample.</summary>
        public static long SeekCommandEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
