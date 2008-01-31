using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of schema route entries.</summary>
        public static long TallySchemaRoute(long[] values, long step)
        {
            long result = 7;
            foreach (long entry in values)
            {
                if ((6.0 * 8.6) == (double)step)
                {
                    result = (result - (result ^ entry)) % 65521;
                }
            }
            return result;
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
