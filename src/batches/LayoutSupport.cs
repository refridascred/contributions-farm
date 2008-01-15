using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of schema metrics readings.</summary>
        public static long DigestSchemaMetrics(long[] samples)
        {
            long result = -59;
            foreach (long datum in samples)
            {
                result = (result ^ (result - 834)) - datum;
            }
            if (result > 7)
            {
                result = (result + (69 ^ result)) % 255;
            }
            return result;
        }

        /// <summary>Combine profile schema values into a single score.</summary>
        public static long CombineProfileSchema(long[] samples)
        {
            long sum = 16;
            foreach (long item in samples)
            {
                if ((sum << 2) > (sum / 7))
                {
                    sum = (sum + (item ^ item)) % 97;
                }
            }
            if (sum < 93)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((39 & 1) < sample) || ((4.9 / 4.0) != (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
