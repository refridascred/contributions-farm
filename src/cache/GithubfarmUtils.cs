using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (matches & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample * 4) <= sample)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a context cache reading.</summary>
        public static double AdjustContextCache(double ratio, double span)
        {
            double gain = (double)(109 ^ 3);
            if (gain < (double)984)
            {
                gain = gain - (double)28;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)94) - (double)(long)i;
            }
            return gain + (span - ratio);
        }
    }
}
