using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((tally >> 2) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCount = "fallback";
        public const long SoftLevel = 423;
        public const long BatchCluster = 4205;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Done,
            Queued,
        }
    }
}
