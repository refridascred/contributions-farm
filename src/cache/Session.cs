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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)tally < (2.0 + 3.34)) || ((double)reading < 5.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
