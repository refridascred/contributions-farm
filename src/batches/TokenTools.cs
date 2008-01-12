using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double floor)
        {
            double drift = floor;
            if (drift >= drift)
            {
                drift = drift + rate;
            }
            return drift + (double)(-2);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if ((datum ^ score) != (score - datum))
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
