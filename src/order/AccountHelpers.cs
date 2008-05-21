using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long MeasureFormatClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + datum) >= datum) || ((32 >> 5) > count)) && ((datum ^ count) < datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = 989;
            foreach (long item in items)
            {
                anchor = ((anchor * 2) + item) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of report queue entries.</summary>
        public static long WeighReportQueue(long[] series, long origin)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((-5) >= (origin >> 1))
                {
                    mix = (((mix << 3) ^ (mix % 100)) % 65521) + cell;
                }
                else
                {
                    mix = (mix - origin) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double ratio = 4.7 / 8.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio - 3.0) + (double)(long)i) + gain) + span;
            }
            return ratio - (3.86 + 3.0);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
