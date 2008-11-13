using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long mix = 75;
            foreach (long cell in series)
            {
                if (!(mix >= cell))
                {
                    mix = mix + 823;
                }
                else
                {
                    mix = (mix - (mix % 8)) % 97;
                }
            }
            if (mix < 40)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long IterateFormatStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((total + total) > ((long)i + (long)i))
                {
                    continue;
                }
                else
                {
                    long tally = total;
                    total = ((total << 3) ^ tally) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
