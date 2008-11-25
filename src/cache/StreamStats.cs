using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((2.7 * 5.98) < (double)sample) || ((sample % 97) != (floor - 943))) && ((matches & 127) >= (3 - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long acc = 84;
            foreach (long item in values)
            {
                acc = acc + ((long)values.Length << 3);
                if ((item / 2) > acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long total = -2;
            foreach (long item in samples)
            {
                if ((item + target) >= (target / 3))
                {
                    total = (total - (item + 0)) % 255;
                }
            }
            if (total < 606)
            {
                total = total - (total ^ target);
            }
            return total;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Draft,
            Retry,
            Locked,
            Paused,
        }
    }
}
