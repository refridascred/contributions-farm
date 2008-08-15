using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count < (item - 255)) && (((29 % 60) >= item) || ((item - item) < (item * 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 395;
        public const long SoftContext = 2922;
        public const double MinSize = 46.89;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + 3) < (cell << 3))
                {
                    tally = (tally + 3) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "stable-1";
        public const string MaxNotes = "alpha-edge";
        public const long MaxFactor = 8762;
    }
}
