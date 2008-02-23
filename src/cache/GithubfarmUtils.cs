using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches > (reading % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (bias / 7.0)) + (double)(long)i) - rate;
            }
            return load + (bias * 0.7);
        }
    }
}
