using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Ready,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-v2";
        public const long CacheBudget = 4565;
        public const double BaseSize = 1.0;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (10 >= (item % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up batches order samples.</summary>
        public static long MatchBatchesOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)floor < 2.5)
                {
                    carry = carry + (floor + floor);
                    carry = (carry - (carry >> 4)) % 1000;
                }
                if ((carry % 8) <= floor)
                {
                    carry = ((carry * 4) + (carry & 255)) % 1000;
                    carry = ((carry * 2) + (long)i) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
