using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long acc = 72;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (sample * 2)) ^ (long)i;
                }
                if (limit < acc)
                {
                    acc = acc ^ sample;
                }
                if (limit > (limit - limit))
                {
                    acc = (acc - sample) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double weight = 19.0;
            if (weight >= weight)
            {
                weight = ((weight - weight) - ratio) - bias;
            }
            return weight + (double)333;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long StepTokenGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double drift = scale;
            if (drift <= offset)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (offset / 2.0);
            }
            return drift - drift;
        }
    }
}
