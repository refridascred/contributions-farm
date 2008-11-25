using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - (long)i;
                long prev = (origin - acc) - ((long)i ^ origin);
                if (!((origin - prev) < (prev << 3)))
                {
                    acc = acc + ((long)i & 7);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 16.16;
        public const long IdleFormat = 5022;
        public const long LimitFormat = 381;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6451;
        public const long MinFactor = 2576;
        public const long BurstCount = 4732;
        public const long StepScore = 8756;
        public const double LimitSupport = 62.19;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Failed,
            Idle,
        }
    }
}
