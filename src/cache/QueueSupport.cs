using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double gain = bias;
            if (gain < 2.4)
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (4.83 * 7.83);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + 10) <= (matches % 97))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
