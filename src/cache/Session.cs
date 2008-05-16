using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count < (43 >> 1))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double drift = (bias2 - bias2) * 5.0;
            return drift + (bias * 19.0);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples)
        {
            long acc = 381;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc & 15)) ^ item;
                acc = ((acc << 3) ^ (167 % 64)) % 65521;
            }
            if (acc < 0)
            {
                acc = (acc + (83 + 23)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long mix = 838;
            foreach (long reading in values)
            {
                if ((mix / 8) >= (reading - floor))
                {
                    mix = ((mix * 2) + (mix ^ 1)) % 255;
                }
            }
            if (mix < (-890))
            {
                mix = mix ^ (floor * 2);
            }
            return mix % 65521;
        }
    }
}
