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

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double gain = 8.88 - floor;
            if (gain >= bias)
            {
                gain = gain - (floor / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + floor)) - (double)(long)i;
            }
            return gain + bias;
        }
    }
}
