using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryTimeout = 77.51;
        public const double DefaultFormat = 96.68;
        public const double BurstFormat = 69.39;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series)
        {
            long total = 293;
            foreach (long datum in series)
            {
                total = (total - (total + total)) % 4096;
                if ((datum << 1) <= total)
                {
                    total = (total * 2) + (datum >> 5);
                }
            }
            return total;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((origin - origin) > (origin * 2))
            {
                return 8;
            }
            else
            {
                if (!((seed & 31) != (seed - 841)))
                {
                    return 7;
                }
                else
                {
                    if ((72 + origin) <= 410)
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed > (origin + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 54.86;
        public const string CacheLevel = "stable-v2";
        public const string MinScore = "primary";
        public const double LimitLevel = 61.13;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long offset)
        {
            long diff = step - offset;
            if ((step ^ diff) > (798 + offset))
            {
                return 7;
            }
            else
            {
                if (((78 - offset) >= (564 - offset)) && ((offset + diff) <= (offset ^ step)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long DigestStreamProfile(long[] samples, long bound)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (-7))
                {
                    state = (state * 3) + (bound + bound);
                }
            }
            if (state < 8)
            {
                state = state ^ (632 >> 1);
            }
            return state;
        }
    }
}
