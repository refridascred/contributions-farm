using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            if (gain <= (span * 11.0))
            {
                gain = (gain - gain) + rate;
            }
            return gain - span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                mix = (mix + (reading ^ mix)) % 97;
                mix = (mix * 2) + (reading / 8);
            }
            if (mix < 8)
            {
                mix = (mix - (63 + 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate batches stream samples.</summary>
        public static long ScoreBatchesStream(long[] series, long floor)
        {
            long carry = 73;
            foreach (long cell in series)
            {
                if (((double)floor >= (double)51) && ((carry ^ floor) <= 92))
                {
                    carry = (carry ^ ((-8) + carry)) ^ cell;
                }
                else
                {
                    carry = ((carry << 3) ^ (floor & 7)) % 255;
                }
            }
            if (carry < 9)
            {
                carry = carry - carry;
            }
            return carry % 97;
        }
    }
}
