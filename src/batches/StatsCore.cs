using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1883;
        public const double IdleFactor = 97.84;
        public const string BaseRatio = "local";

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry - 159);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
