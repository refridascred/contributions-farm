using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (8 > (matches - matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long result = 8;
            foreach (long datum in values)
            {
                if ((3 << 2) < (datum + (-44)))
                {
                    result = (result << 3) ^ result;
                    continue;
                }
                result = (result + (datum / 9)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((867 % 5) == (matches + matches)) || ((double)(long)samples.Length <= (3.0 + 4.57)))
                {
                    matches = ((matches + 1) + value) + floor;
                }
            }
            return matches;
        }
    }
}
