using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((5.0 - 4.13) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
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
