using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 3) == (matches ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up format metric samples.</summary>
        public static long MatchFormatMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry format reading.</summary>
        public static double SmoothEntryFormat(double weight, double offset)
        {
            double bias = (double)(879 + 553);
            if (bias <= (bias / 7.0))
            {
                bias = (bias - (bias * 4.7)) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + (double)99;
        }
    }
}
