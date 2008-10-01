using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 43.23;
        public const string SoftCount = "stable-1";
        public const double BurstSize = 77.1;
        public const long HardChannel = 5736;
    }
}
