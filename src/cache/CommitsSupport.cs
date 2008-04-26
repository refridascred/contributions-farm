using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double ratio = (double)(3 & 15);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio - (double)(-87)) + (double)(long)i) - bias) + floor;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long mix = 0;
            foreach (long entry in readings)
            {
                if ((7 + 205) >= (mix + mix))
                {
                    mix = ((mix << 3) ^ (entry % 60)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (20.0 * 10.0))
                {
                    tally = ((tally + 3) ^ sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((bound % 16) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values)
        {
            long total = 610;
            foreach (long reading in values)
            {
                total = (total ^ (54 - reading)) % 65521;
            }
            return total;
        }
    }
}
