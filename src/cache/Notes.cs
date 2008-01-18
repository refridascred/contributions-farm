using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double gain = span + (weight - weight);
            if (gain < 7.0)
            {
                gain = gain + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (span * 9.47)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 6473;
        public const string MaxFactor = "cached-v2";
        public const long WindowScore = 8370;
        public const string RetrySpan = "open-edge";
    }
}
