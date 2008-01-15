using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long OverlapSchemaAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long target)
        {
            long acc = 17;
            foreach (long cell in readings)
            {
                if ((cell & 7) != (target + target))
                {
                    acc = (acc + (acc - target)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Ready,
            Closed,
            Failed,
        }
    }
}
