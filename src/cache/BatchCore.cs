using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((((long)series.Length + seen) >= (5 & 1)) && ((datum / 9) == ((-1) - step))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) != (entry & 255))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - matches) == (cell << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of payload cache readings.</summary>
        public static long ComparePayloadCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
