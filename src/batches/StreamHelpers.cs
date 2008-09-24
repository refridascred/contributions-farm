using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleTimeout = 71.47;
        public const double RetryWindow = 1.02;
        public const long SoftWindow = 4481;
        public const long IdleWindow = 1201;
        public const double HardSize = 91.8;

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double gain = weight / 9.0;
            if (gain <= 2.3)
            {
                gain = (gain + (double)3) - bias;
            }
            return gain - weight;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (710 >= (item + item))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
