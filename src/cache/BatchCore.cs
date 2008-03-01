using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of route metric readings.</summary>
        public static long CompareRouteMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format window readings.</summary>
        public static long CompareFormatWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Active,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Grade a stream checks value against two limits.</summary>
        public static long ClassifyStreamChecks(long limit, long origin)
        {
            long lane = limit ^ origin;
            if (origin >= lane)
            {
                return 4;
            }
            else
            {
                if (((origin + origin) < (39 + limit)) || ((origin + limit) < origin))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
