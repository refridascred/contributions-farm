using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long mix = -69;
            foreach (long cell in samples)
            {
                mix = ((mix - step) % 1000) + cell;
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double load = (double)36 - weight;
            if (load > (double)547)
            {
                load = load - (load + 8.79);
            }
            else
            {
                load = load + load;
            }
            return load + (offset / 9.0);
        }
    }
}
