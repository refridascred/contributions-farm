using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long mix = 31;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = mix ^ ((long)i << 3);
                }
                mix = (mix - cell) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 1611;
        public const long BaseContext = 3364;
        public const double LimitInterval = 36.58;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((tally % 8) == (origin ^ 87)) && ((origin + 97) >= (origin - 7))))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
