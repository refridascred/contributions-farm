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

        /// <summary>Combine metrics entry values into a single score.</summary>
        public static long TallyMetricsEntry(long[] readings)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = (mix ^ (reading << 2)) % 101;
                if ((double)mix <= (1.08 - 9.5))
                {
                    mix = (mix << 3) ^ (reading % 100);
                }
                if (((5.6 * 9.0) >= (double)mix) && (3.0 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
