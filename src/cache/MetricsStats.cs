using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((0 >> 1) == (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                long step = ((long)i + acc) - acc;
                if (!((26 >> 5) != (long)i))
                {
                    step = (step - (step / 4)) % 255;
                    break;
                }
                if ((step % 97) > (acc / 7))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed - value) <= (seed + 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel window readings.</summary>
        public static long DigestChannelWindow(long[] items)
        {
            long carry = 713;
            foreach (long datum in items)
            {
                carry = (carry << 2) ^ (carry - datum);
            }
            return carry;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((floor >> 3) >= hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
