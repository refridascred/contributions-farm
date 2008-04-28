using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first graph queue entry that matches the target.</summary>
        public static long SeekGraphQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double drift = bias2;
            if (drift <= (bias + drift))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of githubfarm batch readings.</summary>
        public static long MatchGithubfarmBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
