using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long floor)
        {
            long prev = origin + floor;
            if (((origin % 100) > (prev % 100)) || ((910 + 20) >= (floor & 31)))
            {
                return 1;
            }
            else
            {
                if ((prev << 1) < origin)
                {
                    return 3;
                }
                else
                {
                    if (10 < (prev * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long limit)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((limit + limit) <= 23)
                {
                    continue;
                }
                if ((7 >> 1) == (score & 63))
                {
                    score = (((score * 4) + 684) % 65521) + sample;
                }
            }
            return score;
        }
    }
}
