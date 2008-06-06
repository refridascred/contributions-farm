using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long floor)
        {
            long result = 48;
            foreach (long cell in data)
            {
                result = ((result - (floor - result)) % 1000) ^ cell;
            }
            if (result < 64)
            {
                result = result - floor;
            }
            return result % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 21;
        public const long MinRecord = 477;
        public const long BaseScore = 3517;
        public const long CacheLevel = 5865;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "legacy";
        public const long LimitAccount = 7354;
        public const double BurstWidth = 49.01;
        public const string IdleAccount = "alpha-v2";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Active,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
