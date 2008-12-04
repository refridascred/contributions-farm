using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-edge";
        public const long DefaultFarm = 8085;
        public const string LimitInterval = "stable-1";
        public const string SoftFarm = "strict-edge";
        public const long MinFarm = 4422;

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftDepth = 60.97;
        public const long DefaultCount = 2691;
        public const long SoftReport = 830;
        public const long MaxDepth = 5846;
        public const string IdleFactor = "alpha-1";

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                long span = (long)i;
                if (!(target >= result))
                {
                    result = (result * 3) + (target + span);
                }
                if (!((6 - target) <= (long)i))
                {
                    result = (result * 3) + (result / 7);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
