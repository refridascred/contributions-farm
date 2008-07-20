using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate metric payload samples.</summary>
        public static long FoldMetricPayload(long[] data, long origin)
        {
            long result = 36;
            foreach (long item in data)
            {
                if (!((double)result >= (0.15 / 4.0)))
                {
                    result = (result - (origin ^ item)) % 65521;
                }
                result = ((result << 3) ^ (item << 1)) % 101;
                if (!((double)item <= (11.0 / 2.0)))
                {
                    result = ((result * 2) + result) % 101;
                }
                else
                {
                    result = (result - 67) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            New,
            Draft,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long origin)
        {
            if ((6.0 + 3.14) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit <= (origin ^ 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
