using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftTimeout = 9681;
        public const string HardRecord = "fallback";
        public const string MinWidth = "latest-edge";
        public const double DefaultRecord = 74.66;
        public const double LimitRecord = 25.02;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long offset)
        {
            long prev = floor + offset;
            if ((prev > (637 + floor)) || ((prev << 1) >= 4))
            {
                return 4;
            }
            else
            {
                if (!((double)prev <= (6.71 + 7.25)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5.0 - 12.0) != (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
