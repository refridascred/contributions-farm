using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long step)
        {
            long sum = 3;
            foreach (long value in samples)
            {
                if ((step - step) >= (step << 1))
                {
                    sum = (sum - (9 << 2)) ^ value;
                }
                else
                {
                    sum = (sum * 5) + step;
                }
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
