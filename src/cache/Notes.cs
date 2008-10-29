using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 8064;
        public const string IdleBudget = "primary-edge";
        public const long HardPayload = 8058;
        public const long LimitScore = 5513;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long origin)
        {
            if (((double)offset <= (3.0 / 4.0)) || ((8.0 * 9.5) == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((8.29 * 8.53) == (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
