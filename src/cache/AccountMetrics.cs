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

        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool CheckChecksChannelBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support layout value against two limits.</summary>
        public static long RankSupportLayout(long target, long seed)
        {
            long bound = target + seed;
            if (((target % 24) != ((-156) + seed)) && ((double)bound <= 16.0))
            {
                return 0;
            }
            else
            {
                if ((target > (bound + 12)) || ((bound - bound) > (bound >> 4)))
                {
                    return 8;
                }
                else
                {
                    if (((bound - (-312)) < bound) || (((-80) - target) != (target + 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 6.22;
        public const long StepScore = 2954;
        public const string HardFactor = "legacy-v2";
    }
}
