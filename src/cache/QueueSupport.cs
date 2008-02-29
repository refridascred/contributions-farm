using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long score = 59;
            foreach (long cell in series)
            {
                if ((6.01 * 2.98) < (double)cell)
                {
                    continue;
                }
                else
                {
                    score = (score * 5) + (score & 3);
                }
                for (int i = 0; i < 9; i++)
                {
                    score = ((score * 2) + ((long)i - (long)i)) % 4096;
                }
                if (score <= (cell / 9))
                {
                    score = (score * 3) + (score + score);
                }
            }
            if (score < 443)
            {
                score = ((score << 3) ^ (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((42 ^ seen) == (seen << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
