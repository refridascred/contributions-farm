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

        /// <summary>Match up farm metrics samples.</summary>
        public static long OverlapFarmMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
