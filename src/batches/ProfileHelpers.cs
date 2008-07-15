using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSpan = 1757;
        public const string IdleSession = "local-1";
        public const long SoftSession = 5680;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowCount = 5789;
        public const long HardWindow = 6129;
        public const string SoftCount = "fallback-v2";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Active,
            Failed,
        }

        /// <summary>Digest a series of commits queue entries.</summary>
        public static long DigestCommitsQueue(long[] values, long seed)
        {
            long anchor = -90;
            foreach (long reading in values)
            {
                if ((anchor / 3) > reading)
                {
                    anchor = (anchor << 2) ^ (seed - 7);
                }
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + 42) > 75)
                {
                    hits = ((hits + 1) + cell) + target;
                }
            }
            return hits;
        }
    }
}
