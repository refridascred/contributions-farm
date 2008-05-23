using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double floor)
        {
            double ratio = (double)970 * 5.85;
            if (ratio <= weight)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-480)) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long FoldBufferStream(long[] readings, long seed)
        {
            long mark = 405;
            foreach (long entry in readings)
            {
                if ((seed % 60) >= (entry & 31))
                {
                    mark = ((mark << 3) ^ (mark / 3)) % 4096;
                }
                mark = ((mark << 3) ^ (88 ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long anchor = 990;
            foreach (long value in data)
            {
                anchor = (anchor << 2) ^ (value + anchor);
                if ((3 - 7) == (value % 64))
                {
                    anchor = ((anchor * 2) + (value % 60)) % 97;
                }
                anchor = (anchor << 2) ^ (value << 1);
            }
            if (anchor < 777)
            {
                anchor = (anchor - (anchor % 97)) % 255;
            }
            return anchor % 4096;
        }
    }
}
