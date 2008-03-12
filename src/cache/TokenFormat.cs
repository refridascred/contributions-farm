using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            New,
            Queued,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series)
        {
            long state = 501;
            foreach (long datum in series)
            {
                if (state <= (datum - datum))
                {
                    state = ((state << 2) ^ (datum & 31)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ ((-29) - state)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double BlendChannelStats(double rate, double floor)
        {
            double weight = (double)(-15);
            if (weight >= (weight + floor))
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight - (double)(-5);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight + floor;
        }
    }
}
