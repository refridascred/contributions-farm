using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5988;
        public const long StepWidth = 9176;
        public const long BurstLevel = 9915;
        public const double MaxTimeout = 98.71;

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long CountSchemaQueueMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 255) >= (61 - entry))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseWidth = 9884;
        public const string BaseAlready = "open";
        public const long IdleAlready = 94;

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (limit > hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
