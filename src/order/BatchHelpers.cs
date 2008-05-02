using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((3.7 * 1.09) < (double)seen)
                {
                    seen = ((seen + 3) - entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long MeasureCommandBatchHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) >= (item % 12))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
