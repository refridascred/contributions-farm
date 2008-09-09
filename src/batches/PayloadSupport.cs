using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes schema pair into a bucket.</summary>
        public static long BucketNotesSchema(long offset, long bound)
        {
            if ((5.2 + 4.6) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) <= (81 / 5))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < (4 % 16))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine report entry values into a single score.</summary>
        public static long WeighReportEntry(long[] samples, long step)
        {
            long anchor = 462;
            foreach (long cell in samples)
            {
                if (cell > ((-4) - step))
                {
                    anchor = anchor ^ (cell / 6);
                }
                if ((double)step >= (18.0 + 1.3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
