using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = (scale - 13.0) - bias;
            }
            else
            {
                scale = scale + (span * 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally + tally) == (sample & 7)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((-30) > (step >> 4))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels, long seed)
        {
            long total = 39;
            foreach (long entry in levels)
            {
                total = total + (96 + 41);
                total = ((total * 3) + (seed + entry)) % 101;
            }
            return total % 4096;
        }
    }
}
