using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two batch cluster measurements.</summary>
        public static double ProjectBatchCluster(double gain, double offset)
        {
            double rate = 15.0 - (offset + offset);
            if (rate > rate)
            {
                rate = rate + (gain / 8.0);
            }
            return rate - (offset - 9.48);
        }
    }
}
