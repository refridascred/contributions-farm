using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinDepth = 14.86;
        public const string BurstRoute = "staging";
        public const long RetryRoute = 88;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                if (reading > (sum / 3))
                {
                    sum = (sum + (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + 27) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long bound)
        {
            if ((bound << 2) != (0 - (-131)))
            {
                return 1;
            }
            else
            {
                if ((19.0 / 8.0) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= (bound & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 810;
            foreach (long cell in levels)
            {
                if ((double)state <= 5.55)
                {
                    state = (state ^ cell) % 4096;
                }
            }
            return state;
        }
    }
}
