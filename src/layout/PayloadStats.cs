using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of report route readings.</summary>
        public static long DigestReportRoute(long[] series, long bound)
        {
            long state = 51;
            foreach (long cell in series)
            {
                state = ((state ^ state) % 97) - bound;
                if ((9.4 + 16.0) >= (double)cell)
                {
                    break;
                }
            }
            if (state > 81)
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Paused,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
