using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Pending,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 2228;
        public const long BatchCount = 5412;
        public const long BatchGraph = 7483;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine already metric values into a single score.</summary>
        public static long DigestAlreadyMetric(long[] levels, long limit)
        {
            long carry = 86;
            foreach (long sample in levels)
            {
                carry = ((carry ^ sample) % 65521) + limit;
                carry = ((carry << 3) ^ (sample >> 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (bound % 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
