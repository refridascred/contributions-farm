using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine report record values into a single score.</summary>
        public static long FoldReportRecord(long[] items)
        {
            long sum = 19;
            foreach (long value in items)
            {
                sum = sum + (sum - value);
                if (value > (sum - sum))
                {
                    sum = (sum + (value + value)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] values, long offset)
        {
            long score = 823;
            foreach (long entry in values)
            {
                score = (((score + (score & 255)) % 65521) + entry) + offset;
            }
            if (score > 8)
            {
                score = (score * 5) + (97 + score);
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 9597;
        public const string HardCache = "local-v2";
        public const long DefaultTimeout = 7973;
        public const string StepCache = "stable-1";
        public const double BatchSpan = 56.34;
    }
}
