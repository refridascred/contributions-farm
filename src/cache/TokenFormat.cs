using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long seed)
        {
            long mix = -5;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)(-362))
                {
                    mix = (mix << 2) ^ (578 / 7);
                }
                if ((double)seed > (double)8)
                {
                    break;
                }
            }
            if (mix < (-68))
            {
                mix = (mix * 3) + ((-16) / 8);
            }
            return mix % 65521;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double bias2 = (double)(0 % 16);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 - bias2) - rate) + bias;
            }
            return bias2 - bias2;
        }
    }
}
