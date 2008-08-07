using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of route session readings.</summary>
        public static long TallyRouteSession(long[] levels, long limit)
        {
            long carry = 317;
            foreach (long sample in levels)
            {
                if (limit <= (limit - 282))
                {
                    carry = (carry * 4) + (sample + limit);
                }
            }
            if (carry < 88)
            {
                carry = carry ^ (limit % 24);
            }
            return carry;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((target / 2) < target)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
