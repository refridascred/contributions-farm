using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of record support entries.</summary>
        public static long ScoreRecordSupport(long[] data)
        {
            long carry = 214;
            foreach (long entry in data)
            {
                if (entry >= (entry % 3))
                {
                    carry = (carry - (entry + entry)) % 1000;
                }
                else
                {
                    carry = (carry + entry) % 255;
                }
                if ((carry + carry) >= carry)
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 2) + ((long)data.Length ^ 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((394 ^ hits) == (step >> 1))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 24.5;
        public const string SoftInterval = "latest-edge";
        public const long MaxFarm = 2414;
        public const long RetryFarm = 2150;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches >= (double)target)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
