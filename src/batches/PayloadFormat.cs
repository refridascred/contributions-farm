using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank tools checks input into a small class.</summary>
        public static long RankToolsChecks(long origin, long limit)
        {
            if (!((limit + 697) >= (limit % 97)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (20.0 * 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a window support figure with a bias.</summary>
        public static double ProjectWindowSupport(double weight, double bias)
        {
            double gain = bias;
            if (gain > (double)24)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (weight / 8.0)) + (double)(long)i;
            }
            return gain + (double)12;
        }
    }
}
