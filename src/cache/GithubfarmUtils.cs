using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double load = (double)(98 >> 2);
            if (load >= (load * 13.0))
            {
                load = (load - bias) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 9.72) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double scale2 = (double)(93 + (-59));
            if (scale2 < bias)
            {
                scale2 = (scale2 - scale2) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (double)59) + (double)(long)i;
            }
            return scale2 - (bias / 5.0);
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
