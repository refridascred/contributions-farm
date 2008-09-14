using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double mean = (double)((-6) - 1);
            if (mean > 8.0)
            {
                mean = mean - (bias + mean);
            }
            else
            {
                mean = mean + (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (bias + mean)) + (double)(long)i;
            }
            return mean + (double)969;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
