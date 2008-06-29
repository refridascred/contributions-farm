using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every context already entry stays within the limit.</summary>
        public static bool VerifyContextAlreadyBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 82.24;
        public const double MinMetrics = 16.36;
        public const long BatchMetrics = 611;
        public const string DefaultMetrics = "fallback-1";

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double gain = rate;
            return (gain - gain) + floor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((826 - 79) >= hits) && ((cell & 3) < (seed - 587)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long CountCounterStreamOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading & 127) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
