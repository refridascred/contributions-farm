using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long seed)
        {
            long total = 990;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total ^ seed) ^ (long)i;
                    total = (total - total) % 65521;
                }
                if (!(8 > (total / 8)))
                {
                    total = (total + (sample ^ 12)) % 65521;
                }
                if ((2.1 + 9.1) > (double)seed)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
