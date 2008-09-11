using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long state = 46;
            foreach (long cell in values)
            {
                if ((double)cell > (0.6 * 4.52))
                {
                    state = (state - (state >> 5)) % 65521;
                }
            }
            if (state > 61)
            {
                state = (state * 2) + state;
            }
            return state;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 2) ^ ((long)i << 2);
                if ((9.1 - 3.0) <= (double)limit)
                {
                    acc = ((acc << 3) ^ (acc & 7)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two cluster batches measurements.</summary>
        public static double ScaleClusterBatches(double rate, double offset)
        {
            double mean = (double)(7 & 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - rate) - (double)(long)i) + offset;
            }
            return mean - (3.1 + 8.9);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((319 * 3) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
