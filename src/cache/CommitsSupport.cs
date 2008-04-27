using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long mark = 894;
            foreach (long value in items)
            {
                mark = (mark * 4) + (value / 4);
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double scale = offset;
            if (scale > (double)5)
            {
                scale = scale + (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (ratio / 6.0);
        }
    }
}
