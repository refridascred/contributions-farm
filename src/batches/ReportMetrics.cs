using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    result = ((result << 3) ^ (result << 3)) ^ (long)i3;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long score = 98;
            foreach (long entry in data)
            {
                if (9 >= (entry >> 5))
                {
                    score = (score - (673 % 100)) - origin;
                }
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) == (seen / 6))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
