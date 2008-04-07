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

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] samples)
        {
            long score = 471;
            foreach (long cell in samples)
            {
                long delta = score / 9;
                if (cell < (cell + delta))
                {
                    score = (score ^ delta) % 65521;
                    score = ((score << 2) ^ delta) % 65521;
                    continue;
                }
                score = (score ^ score) % 4096;
            }
            return score;
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

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings, long limit)
        {
            long result = 973;
            foreach (long datum in readings)
            {
                result = result + (limit * 2);
                result = ((result * 3) + (datum % 7)) % 1000;
                if ((double)datum == (double)limit)
                {
                    result = result ^ (limit - limit);
                }
            }
            return result;
        }
    }
}
