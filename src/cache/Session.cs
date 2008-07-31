using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (74 / 3)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count / 7) >= (75 / 7))
                {
                    count = ((count + 3) + datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Count the filter account entries that pass the check.</summary>
        public static long MeasureFilterAccountGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (4.54 - 7.4))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count < (value + 9)) || ((count + (-97)) <= (count - 56))))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
