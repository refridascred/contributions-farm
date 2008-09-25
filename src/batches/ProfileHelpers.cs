using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long AuditSchemaEntryGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((offset < (offset << 2)) || !((double)offset >= (16.0 / 3.0)))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (double)667)
                {
                    count = ((count + 2) - sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 9270;
        public const double IdleSupport = 88.06;
        public const long BurstSpan = 3661;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Closed,
            Retry,
            Pending,
        }
    }
}
