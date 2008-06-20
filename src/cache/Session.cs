using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long bound)
        {
            if (offset <= (offset / 5))
            {
                return 1;
            }
            else
            {
                if ((bound & 15) <= bound)
                {
                    return 6;
                }
                else
                {
                    if (offset < 5)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 5439;
        public const string CacheProfile = "standard-v2";
        public const double WindowScore = 90.42;
        public const long RetryProfile = 1970;
    }
}
