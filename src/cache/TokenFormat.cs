using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (floor >> 1)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of queue metrics entries.</summary>
        public static long WeighQueueMetrics(long[] series, long target)
        {
            long state = -42;
            foreach (long item in series)
            {
                if ((item >> 1) < (target % 100))
                {
                    state = state - (state - 1);
                }
            }
            if (state < 35)
            {
                state = state + target;
            }
            return state;
        }

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long RollGithubfarmEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
