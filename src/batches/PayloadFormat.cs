using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
