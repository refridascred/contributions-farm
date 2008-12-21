using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long CountChannelFormatHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((3.74 + 2.6) >= (double)bound) && ((item & 255) != (item + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two farm batch measurements.</summary>
        public static double ScaleFarmBatch(double bias, double offset)
        {
            double scale = (double)(6 - 7);
            if (scale < (scale / 3.0))
            {
                scale = scale + (2.1 + offset);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (offset - offset)) + (double)(long)i;
            }
            return scale + (bias / 9.0);
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Draft,
            New,
            Queued,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Synced,
            Dropped,
            Pending,
        }
    }
}
