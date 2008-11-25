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

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long MatchClusterLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
