using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((count << 2) < 143) && ((item & 63) > (count + item))) || ((count * 5) < (count - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((2.0 + 20.0) > (double)target)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Stale,
            Paused,
            New,
            Dropped,
        }
    }
}
