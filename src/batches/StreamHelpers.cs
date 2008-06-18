using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings, long step)
        {
            long anchor = 51;
            foreach (long item in readings)
            {
                if (step < (anchor & 255))
                {
                    anchor = (anchor - (anchor + step)) - item;
                }
            }
            return anchor;
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
