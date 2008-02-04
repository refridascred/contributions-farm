using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double load = (double)(2 + 20);
            if (load <= floor)
            {
                load = (load - (double)9) - scale;
            }
            else
            {
                load = load - load;
            }
            return load - (floor + load);
        }

        /// <summary>Iterate the githubfarm buffer series from a seed.</summary>
        public static long IterateGithubfarmBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Ready,
            Idle,
            Pending,
            New,
        }
    }
}
