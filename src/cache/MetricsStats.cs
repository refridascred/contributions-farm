using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a support contributi reading.</summary>
        public static double AdjustSupportContributi(double gain, double span)
        {
            double scale = span - span;
            if (scale < (double)(-7))
            {
                scale = (scale + span) + gain;
            }
            else
            {
                scale = scale + 5.1;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (1.0 / 4.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardScore = 17.52;
        public const double MinFarm = 55.46;
        public const string MinScore = "open-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 4684;
        public const long RetryWidth = 9953;
        public const string IdleAlready = "latest";
        public const long BatchAlready = 4394;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Idle,
            Synced,
            Pending,
            New,
        }
    }
}
