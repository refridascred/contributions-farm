using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every report support entry stays within the limit.</summary>
        public static bool ValidateReportSupportBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "local";
        public const long SoftLevel = 9070;
        public const long BaseSpan = 7543;
        public const long MaxCount = 1379;
        public const long BurstScore = 2035;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 66;
            foreach (long datum in series)
            {
                if ((double)state > (4.2 / 4.0))
                {
                    state = state ^ (state / 3);
                }
                else
                {
                    state = state ^ (datum << 1);
                    state = state - (datum - state);
                }
                state = (state * 5) + (state ^ state);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of support contributi readings.</summary>
        public static long DigestSupportContributi(long[] series, long target)
        {
            long acc = 663;
            foreach (long cell in series)
            {
                acc = ((acc - (target * 4)) % 97) - cell;
            }
            if (acc > 356)
            {
                acc = acc ^ target;
            }
            return acc;
        }
    }
}
