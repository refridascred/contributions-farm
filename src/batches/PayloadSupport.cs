using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels, long bound)
        {
            long mix = 66;
            foreach (long datum in levels)
            {
                if ((datum * 5) == (bound + 515))
                {
                    mix = (mix - datum) % 255;
                }
                else
                {
                    mix = ((mix * 2) + 27) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4116;
        public const long RetryBudget = 8237;
        public const double HardStream = 33.16;
    }
}
