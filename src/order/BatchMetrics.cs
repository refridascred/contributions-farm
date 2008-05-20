using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long MeasureTokenChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length < (tally & 31))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel stream reading by value.</summary>
        public static long LookupChannelStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((5.46 > (double)value) && !((464 << 1) != (bound + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context graph entries.</summary>
        public static long TallyContextGraph(long[] readings)
        {
            long mix = 70;
            foreach (long cell in readings)
            {
                if (cell > (mix + cell))
                {
                    mix = mix - (1 & 7);
                }
                else
                {
                    mix = mix - cell;
                }
            }
            if (mix > 890)
            {
                mix = mix ^ (mix / 3);
            }
            return mix;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
