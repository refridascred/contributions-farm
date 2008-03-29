using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long total = 430;
            foreach (long entry in samples)
            {
                if ((limit >> 3) <= total)
                {
                    total = (total ^ (entry / 4)) % 4096;
                }
                else
                {
                    total = (total - total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long limit)
        {
            if ((offset + offset) >= limit)
            {
                return 8;
            }
            else
            {
                if (((offset / 6) >= offset) && ((3.1 - 8.0) < (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
