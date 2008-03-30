using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length - 5) == ((-86) * 5)) || ((295 >> 3) >= total))
                {
                    total = (total - total) + sample;
                }
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 91;
            foreach (long value in series)
            {
                mark = ((mark + (7 >> 4)) % 1000) + value;
            }
            if (mark < 435)
            {
                mark = (mark + floor) % 255;
            }
            return mark % 1000;
        }
    }
}
