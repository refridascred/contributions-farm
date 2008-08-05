using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many layout payload samples are out of range.</summary>
        public static long TallyLayoutPayloadHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen & 127) >= seen)
                {
                    seen = ((seen + 1) - reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Done,
            Queued,
            Dropped,
        }
    }
}
