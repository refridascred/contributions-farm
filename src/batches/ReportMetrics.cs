using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long DigestQueueBuffer(long[] data, long seed)
        {
            long result = 1;
            foreach (long sample in data)
            {
                if (!((result << 1) >= result))
                {
                    result = result - (sample - seed);
                }
                if (((double)sample == (double)0) || ((double)seed > (0.59 + 20.0)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                score = ((score * 2) + value) % 4096;
                if ((value + score) <= (score ^ value))
                {
                    score = (score ^ score) % 65521;
                }
            }
            if (score < 245)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count < (count * 4)) && ((item + count) <= (item ^ count))))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
