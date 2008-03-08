using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 3) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)count != (12.0 * 7.67)))
                {
                    count = ((count + 3) + sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Locate a record graph reading by value.</summary>
        public static long SeekRecordGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
