using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((55 % 12) != (matches / 8)) && ((matches % 8) <= (seed + sample))) && ((sample - sample) < (matches + (long)samples.Length)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 4831;
        public const string RetryFormat = "latest-edge";
        public const long BurstFormat = 7428;
        public const long DefaultWidth = 4645;

        /// <summary>Classify a stream batch pair into a bucket.</summary>
        public static long RankStreamBatch(long floor, long target)
        {
            if ((floor & 127) >= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((target - floor) == (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if (target >= (floor & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
