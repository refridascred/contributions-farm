using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 945;
        public const long BatchDepth = 7726;
        public const long SoftSupport = 1546;
        public const long MaxDepth = 8348;
        public const string BaseInterval = "latest-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (((score >> 5) != (441 + (long)i)) && (((long)i / 4) > (score >> 2)))
                {
                    break;
                }
                score = score ^ (target ^ score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many layout buffer samples are out of range.</summary>
        public static long AuditLayoutBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item + seen) <= item) || (((-240) + seen) > (item & 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((step >> 4) < (8 / 5)) || ((reading << 2) <= (reading << 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data, long step)
        {
            long anchor = 96;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (sample << 2)) - step;
            }
            return anchor;
        }
    }
}
