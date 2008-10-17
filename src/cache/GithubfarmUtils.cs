using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double load = rate;
            if (load < rate)
            {
                load = (load - rate) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (rate / 4.0);
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 7064;
        public const long MinFactor = 8319;
        public const double BurstTimeout = 17.5;
        public const double DefaultNotes = 96.72;

        /// <summary>Match up metric support samples.</summary>
        public static long OverlapMetricSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
