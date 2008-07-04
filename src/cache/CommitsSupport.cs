using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long CountCounterReportHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen + seen) > (seen + datum)) || ((seen - seen) > (seen + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long floor)
        {
            long total = 4;
            foreach (long sample in values)
            {
                if (!((double)(long)values.Length >= (double)total))
                {
                    total = ((total * 3) + (floor ^ floor)) - sample;
                }
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "open-1";
        public const long LimitWidth = 6135;
        public const long DefaultFormat = 3208;
        public const double SoftFormat = 60.46;
        public const long StepFormat = 9815;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
