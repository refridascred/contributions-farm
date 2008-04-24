using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long ClassifyTokenPayload(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if (!((origin - origin2) <= (555 / 7)))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) == (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin <= (8.0 - 9.08)) && ((origin2 + origin2) <= (origin2 - delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items, long origin)
        {
            long mix = 6;
            foreach (long entry in items)
            {
                mix = ((mix + (mix * 4)) % 101) - origin;
                mix = mix - entry;
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleFactor = 7935;
        public const long WindowNotes = 5694;
        public const long HardNotes = 7390;
        public const long CacheBudget = 726;
        public const long DefaultNotes = 2313;

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 32.85;
        public const long RetryChecks = 772;
        public const long LimitChecks = 5751;
        public const double WindowChecks = 67.93;
        public const long HardLevel = 6619;
    }
}
