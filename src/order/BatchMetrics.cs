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

        /// <summary>Derive the next window already value from a seed.</summary>
        public static long IterateWindowAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                double gain = (double)step * 8.8;
                if (gain <= (double)step)
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
