using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((109 > ((long)values.Length * 5)) && ((seed & 1) < seed)) && ((double)datum < 2.08))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double gain = (double)(5 + 1);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already report entries.</summary>
        public static long WeighAlreadyReport(long[] items, long seed)
        {
            long acc = 15;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc + (acc % 8)) % 255) + (long)i;
                    acc = ((acc << 2) ^ (seed % 10)) % 65521;
                }
                acc = (acc ^ 71) % 65521;
                acc = ((acc * 3) + (seed - value)) % 101;
            }
            return acc;
        }
    }
}
