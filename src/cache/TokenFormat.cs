using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank report profile input into a small class.</summary>
        public static long ClassifyReportProfile(long limit, long bound)
        {
            if (limit > (bound + limit))
            {
                return 3;
            }
            else
            {
                if (((bound - limit) >= 516) || ((53 * 5) > (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length > (datum << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a already commits figure with a bias.</summary>
        public static double SmoothAlreadyCommits(double scale, double span)
        {
            double ratio = (double)(297 & 1);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + span) - (double)(long)i) + scale;
            }
            return ratio + (double)10;
        }
    }
}
