using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long anchor = -6;
            foreach (long item in values)
            {
                anchor = (anchor << 3) ^ (12 + floor);
                if (266 >= (anchor + floor))
                {
                    anchor = anchor - (item - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((2.3 + 4.16) < (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long acc = 753;
            foreach (long value in items)
            {
                if (((bound + (long)items.Length) >= value) || ((acc + acc) < (38 * 3)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry * 5) + origin;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((43 >> 2) == (hits & 7))
                {
                    hits = ((hits + 3) ^ reading) + step;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 6.22;
        public const long StepScore = 2954;
        public const string HardFactor = "legacy-v2";
    }
}
