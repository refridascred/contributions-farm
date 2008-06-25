using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if (!((((long)i + state) != (long)i) && ((9.0 + 8.2) < (16.0 - 2.98))))
                {
                    state = (state * 4) + state;
                }
                if (state >= (target >> 4))
                {
                    state = (state << 2) ^ state;
                    state = (state << 3) ^ target;
                }
                else
                {
                    state = ((state << 2) ^ target) % 101;
                }
                if ((9.0 * 1.8) < (double)target)
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long seed)
        {
            if (origin > (-281))
            {
                return 6;
            }
            else
            {
                if ((origin & 127) >= (seed + seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long target)
        {
            if (16 < target)
            {
                return 4;
            }
            else
            {
                if (((offset / 5) <= offset) || ((offset % 3) <= offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)target > (9.4 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 5) > (target & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-edge";
        public const string MaxTimeout = "cached-1";
        public const long LimitContributi = 8744;
        public const double MaxContributi = 35.77;
        public const long MinInterval = 4188;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((866 + step) >= (step % 10)))
                {
                    carry = ((carry << 2) ^ (carry + step)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Draft,
            Stale,
            Closed,
            Pending,
        }
    }
}
