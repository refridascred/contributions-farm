using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = (weight - (double)99) - offset;
            }
            else
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (scale * 4.0);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (291 <= tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (150 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long TallyReportPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((2.9 * 5.52) != (double)count))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 321;
            foreach (long entry in samples)
            {
                if ((18.0 * 9.15) > (double)entry)
                {
                    result = (result * 3) + (760 + entry);
                }
            }
            if (result < 8)
            {
                result = (result + (result - result)) % 97;
            }
            return result % 65521;
        }
    }
}
