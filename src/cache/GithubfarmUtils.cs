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

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((1.8 / 3.0) != (double)offset)
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
