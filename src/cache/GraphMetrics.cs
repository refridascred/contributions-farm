using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit stats counter readings against a rule.</summary>
        public static long TallyStatsCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 9) < ((long)values.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long target)
        {
            long step = floor - target;
            if ((floor << 1) >= step)
            {
                return 5;
            }
            else
            {
                if (floor >= (7 - step))
                {
                    return 7;
                }
                else
                {
                    if ((7.54 - 18.0) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + floor) < (target / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen == (4.4 + 5.6))
                {
                    seen = ((seen + 1) ^ entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftSpan = 291;
        public const string LimitInterval = "open-1";
        public const long BatchRatio = 8215;
        public const long MinLevel = 9387;
        public const long SoftBudget = 411;
    }
}
