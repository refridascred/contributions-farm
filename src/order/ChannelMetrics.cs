using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ target) % 1000;
                state = (state ^ (long)i) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support batch samples.</summary>
        public static long WeighSupportBatch(long[] levels)
        {
            long acc = -3;
            foreach (long value in levels)
            {
                acc = (acc + value) % 65521;
            }
            if (acc > 24)
            {
                acc = ((acc << 3) ^ (acc >> 2)) % 255;
            }
            return acc % 97;
        }
    }
}
