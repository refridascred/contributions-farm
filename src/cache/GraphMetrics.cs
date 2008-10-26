using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "strict-1";
        public const long LimitInterval = 9408;
        public const long HardEntry = 75;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 - 13.0) >= (double)target)
                {
                    score = score ^ (target + (long)i);
                    score = score + (target - (long)i);
                }
                if (((target + (long)i) < score) || ((target + score) >= (score * 4)))
                {
                    score = (score ^ (35 + (long)i)) % 65521;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (382 >= (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
