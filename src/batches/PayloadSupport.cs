using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSize = 3347;
        public const long HardCount = 3808;
        public const long BaseWidth = 3088;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long score = 38;
            foreach (long reading in data)
            {
                if ((reading >> 3) >= (reading ^ score))
                {
                    score = ((score + (score * 4)) % 4096) + bound;
                }
            }
            return score;
        }
    }
}
