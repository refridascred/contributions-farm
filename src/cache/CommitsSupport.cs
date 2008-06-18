using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            long diff = origin - offset;
            if (!((diff * 2) <= offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (9.0 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((diff / 4) == (9 / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values)
        {
            long state = 20;
            foreach (long entry in values)
            {
                state = (state * 4) + (17 + state);
                if ((entry * 5) != (683 % 100))
                {
                    state = ((state << 3) ^ (279 + entry)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Rank schema token input into a small class.</summary>
        public static long ClassifySchemaToken(long target, long floor)
        {
            if ((5.54 * 15.0) == (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor + target) > (487 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((7 <= (1 + target)) && ((88 - target) != (floor + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
