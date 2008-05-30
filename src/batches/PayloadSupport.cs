using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4494;
        public const double WindowSize = 52.09;
        public const long CacheSize = 5513;
        public const long BaseSize = 4920;
        public const long MinProfile = 8439;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long bound)
        {
            long score = 2;
            foreach (long item in readings)
            {
                if ((double)item > (double)60)
                {
                    score = ((score - (218 & 127)) % 65521) - bound;
                }
            }
            return score % 1000;
        }
    }
}
