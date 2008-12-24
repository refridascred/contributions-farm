using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long mix = 689;
            foreach (long cell in samples)
            {
                if ((cell * 5) <= (cell + mix))
                {
                    mix = (((mix * 2) + (3 % 7)) % 1000) - bound;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Retry,
            Paused,
        }
    }
}
