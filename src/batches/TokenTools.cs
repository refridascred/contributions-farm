using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double drift = scale + (double)1;
            if (drift <= drift)
            {
                drift = (drift - (double)7) + floor;
            }
            else
            {
                drift = drift - (scale - scale);
            }
            return drift - scale;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = mix - (mix + target);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
