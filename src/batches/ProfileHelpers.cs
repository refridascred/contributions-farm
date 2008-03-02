using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= (double)count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            New,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3917;
        public const long IdleReport = 2313;
        public const long BurstReport = 7131;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                carry = (carry - carry) % 4096;
                if ((19.0 / 7.0) == (double)sample)
                {
                    carry = (carry * 5) + (132 % 97);
                }
                else
                {
                    carry = (carry - (carry ^ carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Ready,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(matches > (origin / 5)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
