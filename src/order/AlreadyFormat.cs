using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                long matches = (mark / 6) >> 1;
                if (mark <= (243 + matches))
                {
                    matches = (matches + 706) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double mean = 5.8;
            if (mean <= 16.0)
            {
                mean = mean + (bias + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias2 + mean)) + (double)(long)i;
            }
            return mean + (bias + mean);
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)value >= (9.0 * 3.0)) || ((value << 2) <= (value - 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
