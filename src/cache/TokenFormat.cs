using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double mean = (scale / 2.0) - scale;
            if (mean <= 3.9)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (scale * 8.0);
        }

        /// <summary>Match up session editor samples.</summary>
        public static long MatchSessionEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardLevel = 15.48;
        public const long CacheTimeout = 7707;
        public const long BatchWidth = 3232;
        public const long LimitBatch = 5553;
    }
}
