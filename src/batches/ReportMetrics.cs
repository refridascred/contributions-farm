using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long anchor = 54;
            foreach (long reading in values)
            {
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            if (anchor < 748)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 792;
            foreach (long cell in series)
            {
                result = (((result << 3) ^ (272 + 4)) % 255) - cell;
            }
            return result % 4096;
        }
    }
}
