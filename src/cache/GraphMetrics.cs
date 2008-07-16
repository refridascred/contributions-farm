using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double weight, double span)
        {
            double bias = span - (4.8 / 5.0);
            if (bias <= span)
            {
                bias = (bias - span) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (5.99 * 3.6)) + (double)(long)i;
            }
            return bias + (span / 8.0);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
