using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest-v2";
        public const long BatchInterval = 945;
        public const string StepLayout = "standard-1";
        public const string DefaultLayout = "latest-edge";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch contributi reading.</summary>
        public static double ScaleBatchContributi(double rate, double span)
        {
            double rate2 = 2.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 - rate) + (double)(long)i) - span;
            }
            return rate2 + rate2;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((double)next <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((7.34 / 5.0) == (double)origin2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
