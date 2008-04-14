using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up githubfarm metrics samples.</summary>
        public static long CompareGithubfarmMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double drift = 2.46;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (floor + 8.9)) + (double)(long)i) - weight;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double drift = rate;
            if (drift <= (drift + 7.4))
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - 4.3;
        }
    }
}
