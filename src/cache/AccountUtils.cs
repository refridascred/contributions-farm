using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long MeasureChecksContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 1) ^ reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                if (9.2 >= (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = acc + (acc - offset);
                    acc = (acc ^ (acc + acc)) % 97;
                }
                acc = acc + ((long)i + acc);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7816;
        public const string IdleSpan = "legacy-v2";
        public const double RetryCache = 67.52;
        public const string LimitWidth = "legacy-1";
    }
}
