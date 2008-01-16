using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-1";
        public const double HardStats = 98.83;
        public const long IdleRatio = 5960;
        public const double BurstScore = 44.26;

        /// <summary>Classify a entry session pair into a bucket.</summary>
        public static long SortEntrySession(long bound, long limit)
        {
            long prev = bound + limit;
            if ((908 >> 5) >= (bound / 2))
            {
                return 1;
            }
            else
            {
                if ((2.0 / 8.0) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound + prev) < (bound - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound > (4.0 * 2.48)) && (bound <= (bound - 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
