using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target < (double)829) || ((8.09 + 18.0) >= (double)carry))
                {
                    carry = (carry << 2) ^ ((long)i * 4);
                }
                if ((carry + 10) <= ((long)i + target))
                {
                    carry = ((carry << 3) ^ (carry << 3)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((seed * 2) < (701 / 7))
            {
                return 2;
            }
            else
            {
                if ((prev + seed) == (prev % 24))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed > (0.99 + 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the channel entry entries that pass the check.</summary>
        public static long MeasureChannelEntryMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((17 + seed) > (cell >> 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
