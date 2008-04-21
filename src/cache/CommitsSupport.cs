using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit < (long)i)
                {
                    mix = ((mix << 3) ^ ((long)i + mix)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((1.5 / 8.0) < (double)seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of order stream readings.</summary>
        public static long OverlapOrderStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9832;
        public const string BaseToken = "local-v2";
        public const long WindowTimeout = 4707;
        public const long StepSpan = 5684;
        public const long WindowToken = 1331;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
