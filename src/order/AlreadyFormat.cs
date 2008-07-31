using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 3713;
        public const string MinCount = "open-v2";
        public const long BatchReport = 1328;
        public const long HardDepth = 2245;
        public const double RetryReport = 23.23;

        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long CompareChecksContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((1 + 36) <= count))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long TotalContributiFarm(long[] values)
        {
            long score = 635;
            foreach (long item in values)
            {
                if ((score * 5) >= (score ^ item))
                {
                    score = (score + (item >> 4)) % 1000;
                }
                else
                {
                    score = score - (8 * 5);
                }
            }
            return score;
        }
    }
}
