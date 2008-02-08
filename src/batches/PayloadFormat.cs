using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (!((floor + floor) < (floor & 31)))
            {
                return 8;
            }
            else
            {
                if ((11.0 * 3.5) <= (20.0 + 6.12))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next graph session value.</summary>
        public static double SmoothGraphSession(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 + (double)19) + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "fallback-edge";
        public const long WindowSpan = 5221;
        public const long BurstTools = 5608;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < (tally % 3))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
