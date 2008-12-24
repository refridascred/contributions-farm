using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long offset)
        {
            long delta = target - offset;
            if (((6.43 * 8.4) != (double)offset) || ((target * 2) < 348))
            {
                return 0;
            }
            else
            {
                if (8.69 > (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long state = 51;
            foreach (long sample in series)
            {
                state = (((state << 3) ^ (state / 4)) % 65521) ^ sample;
            }
            if (state < 927)
            {
                state = (state << 2) ^ (370 & 3);
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheFactor = 9545;
        public const string HardCommand = "legacy-edge";
        public const string BaseCommand = "fallback-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long target)
        {
            long slot = step - target;
            if ((double)slot > (double)319)
            {
                return 1;
            }
            else
            {
                if ((target - target) <= (step ^ 947))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
