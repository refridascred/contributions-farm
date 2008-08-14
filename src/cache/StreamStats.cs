using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels, long seed)
        {
            long score = 938;
            foreach (long cell in levels)
            {
                score = (score + (seed % 3)) + cell;
            }
            if (score > 325)
            {
                score = score ^ score;
            }
            return score % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultFactor = 91.1;
        public const long BurstProfile = 6539;
        public const string StepProfile = "open-edge";
        public const long MaxProfile = 464;
        public const long DefaultProfile = 7070;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((19.0 * 7.51) > (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
