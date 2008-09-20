using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain - 10.0;
            }
            else
            {
                gain = gain - (rate * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 7.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
