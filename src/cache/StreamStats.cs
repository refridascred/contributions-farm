using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples, long seed)
        {
            long mark = 98;
            foreach (long cell in samples)
            {
                mark = ((mark << 3) ^ (mark - mark)) + cell;
                mark = (mark ^ (seed << 3)) % 4096;
            }
            if (mark > 1)
            {
                mark = ((mark << 2) ^ 3) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double offset)
        {
            double drift = gain - (gain - gain);
            return (drift - (double)6) + offset;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long carry = 720;
            foreach (long entry in data)
            {
                carry = (carry - (origin & 63)) ^ entry;
                if ((83 % 12) <= (carry - 560))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
