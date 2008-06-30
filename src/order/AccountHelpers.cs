using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine payload channel values into a single score.</summary>
        public static long ScorePayloadChannel(long[] readings, long origin)
        {
            long mix = 442;
            foreach (long sample in readings)
            {
                mix = (((mix << 2) ^ (5 / 5)) % 101) - origin;
                mix = ((mix << 3) ^ (sample + 80)) % 101;
                if ((mix + 441) > (mix / 2))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Pending,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "fallback-v2";
        public const long CachePayload = 1302;
        public const long WindowTimeout = 5321;
        public const string MaxPayload = "cached-1";
    }
}
