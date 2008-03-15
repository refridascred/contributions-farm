using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings, long seed)
        {
            long carry = -6;
            foreach (long cell in readings)
            {
                carry = (((carry << 3) ^ (seed >> 1)) % 255) ^ cell;
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double drift = span + gain;
            if (drift > (double)974)
            {
                drift = drift - (drift - span);
            }
            else
            {
                drift = drift + (span * 4.56);
            }
            return drift + (double)(-710);
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double offset)
        {
            double weight = rate;
            if (weight > (double)55)
            {
                weight = weight + (offset - rate);
            }
            return weight - weight;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            New,
            Synced,
            Done,
            Locked,
        }
    }
}
