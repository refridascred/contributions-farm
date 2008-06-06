using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 856;
        public const long RetryTools = 497;
        public const double BaseInterval = 57.38;
        public const long StepSpan = 8121;
        public const double IdleSize = 53.7;

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long GradeSessionMetric(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (offset >= (origin + limit))
            {
                return 2;
            }
            else
            {
                if ((2.66 - 8.4) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= 20.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
