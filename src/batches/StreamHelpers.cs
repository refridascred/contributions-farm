using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many queue session samples are out of range.</summary>
        public static long AuditQueueSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value + value) >= (83 + 477)) || ((double)value <= (0.9 - 8.86)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((entry + hits) == (923 + hits)) || ((hits <= (long)series.Length) || ((entry << 2) == (entry << 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - ((long)i * 3)) % 101;
                sum = (sum ^ 594) % 97;
                sum = ((sum << 3) ^ (94 ^ (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long score = 6;
            foreach (long cell in values)
            {
                if (((cell - cell) < score) && ((double)96 < (double)score))
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            return score % 4096;
        }
    }
}
