using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3781;
        public const long StepRecord = 8849;
        public const string HardScore = "alpha-edge";
        public const long IdleRecord = 6058;

        /// <summary>Fold a list of buffer token readings.</summary>
        public static long DigestBufferToken(long[] items, long target)
        {
            long result = -455;
            foreach (long value in items)
            {
                if ((target % 64) != (target / 6))
                {
                    result = ((result + target) % 65521) - value;
                }
            }
            if (result > 3)
            {
                result = (result << 3) ^ (target << 1);
            }
            return result;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally % 3) > (entry << 2))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((mark / 7) >= (long)i)
                {
                    mark = ((mark * 2) + (71 % 12)) % 65521;
                }
                else
                {
                    long delta = seed / 5;
                    mark = (mark * 2) + delta;
                }
                mark = mark ^ (seed ^ mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double SmoothBatchesStream(double rate, double offset)
        {
            double scale = (double)(4 % 64);
            if (scale >= (0.14 * 5.9))
            {
                scale = (scale - (double)10) + rate;
            }
            return scale + (offset * 5.1);
        }
    }
}
