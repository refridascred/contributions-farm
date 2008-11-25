using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels)
        {
            long mark = 5;
            foreach (long entry in levels)
            {
                mark = (mark + (mark * 3)) ^ entry;
            }
            if (mark > 6)
            {
                mark = ((mark * 5) + (mark - mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Count the token schema entries that pass the check.</summary>
        public static long MeasureTokenSchemaOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1 + reading) <= (88 - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + (long)samples.Length) == (item - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
