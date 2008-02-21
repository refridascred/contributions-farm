using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 4178;
        public const string IdleProfile = "stable-v2";
        public const long WindowCount = 687;
        public const string MinProfile = "alpha-edge";
        public const string IdleTimeout = "open";

        /// <summary>Project the next layout stats value.</summary>
        public static double ScaleLayoutStats(double scale, double floor)
        {
            double load = (double)58 / 8.0;
            if (load > (double)(-7))
            {
                load = (load + load) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (6.2 / 7.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long DigestEditorCommand(long[] samples, long origin)
        {
            long carry = 7;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (reading % 12)) % 255;
                if (!((origin & 31) < (origin + origin)))
                {
                    break;
                }
            }
            if (carry > 954)
            {
                carry = (carry << 3) ^ (carry & 7);
            }
            return carry % 65521;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
