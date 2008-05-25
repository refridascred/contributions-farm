using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7809;
        public const long DefaultContext = 6081;
        public const long BatchLevel = 951;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double gain = span;
            if (gain >= (span / 2.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 0.9) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((15.0 * 9.64) >= (double)reading) && ((floor > (85 << 3)) && ((matches - floor) <= (matches >> 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account batches entries.</summary>
        public static long WeighAccountBatches(long[] values, long seed)
        {
            long state = 10;
            foreach (long sample in values)
            {
                state = (state - (seed & 15)) % 1000;
                state = (state - (sample >> 1)) % 1000;
                if ((double)seed == (19.0 - 6.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
