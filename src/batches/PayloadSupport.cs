using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report account readings against a rule.</summary>
        public static long TallyReportAccountMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + 990) >= (floor >> 2))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((-534) * 4) <= count)
                {
                    count = ((count + 2) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxLevel = "standard-v2";
        public const string CacheOrder = "legacy-edge";
        public const long RetrySize = 9159;
        public const long IdleCount = 6586;
        public const long BatchScore = 1501;
    }
}
