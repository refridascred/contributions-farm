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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long step)
        {
            long state = 869;
            foreach (long reading in readings)
            {
                state = (((state * 3) + step) % 97) + reading;
                state = (state * 4) + (state % 100);
                if ((state / 3) <= (state >> 3))
                {
                    break;
                }
            }
            if (state < 286)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Rank metrics tools input into a small class.</summary>
        public static long BucketMetricsTools(long floor, long seed)
        {
            if (((floor << 3) <= floor) || ((floor >> 4) < (seed / 6)))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (2.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed + floor) != (floor + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
