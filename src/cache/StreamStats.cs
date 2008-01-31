using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] samples, long origin)
        {
            long state = 1;
            foreach (long item in samples)
            {
                state = ((state * 4) + (state + item)) % 4096;
                if (((item << 3) > (946 % 10)) || ((double)origin >= (double)state))
                {
                    state = (state ^ (item * 2)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
