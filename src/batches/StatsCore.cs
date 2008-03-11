using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "latest";
        public const string StepEntry = "latest-v2";
        public const long WindowBudget = 5984;

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 66.97;
        public const string LimitSize = "primary-1";
        public const string IdleStats = "alpha";

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
