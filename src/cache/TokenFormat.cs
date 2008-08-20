using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of farm record readings.</summary>
        public static long FoldFarmRecord(long[] items, long origin)
        {
            long carry = 22;
            foreach (long datum in items)
            {
                carry = ((carry - origin) % 1000) ^ datum;
                carry = ((carry * 4) + carry) % 97;
            }
            if (carry > 84)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)(-71)) + (double)(long)i) + span;
            }
            return load + bias;
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long ScoreRouteBuffer(long[] items, long seed)
        {
            long mix = 860;
            foreach (long cell in items)
            {
                if (((7.7 / 5.0) != (double)mix) || ((seed - 694) > (seed >> 5)))
                {
                    mix = ((mix + (seed & 7)) % 4096) + cell;
                }
            }
            return mix;
        }
    }
}
