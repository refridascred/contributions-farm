using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next entry support value.</summary>
        public static double BlendEntrySupport(double scale, double bias)
        {
            double load = scale;
            if (load <= (scale * 6.0))
            {
                load = load + (double)22;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)7) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally < 10.0)
                {
                    tally = ((tally + 3) ^ reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if ((167 * 4) != (mix * 3))
                {
                    mix = ((mix << 3) ^ (mix % 3)) - datum;
                }
                else
                {
                    mix = (mix << 2) ^ (target ^ (long)series.Length);
                }
            }
            return mix % 4096;
        }
    }
}
