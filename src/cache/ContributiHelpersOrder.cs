using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long offset)
        {
            long diff = target ^ offset;
            if (offset >= (target * 5))
            {
                return 8;
            }
            else
            {
                if (!(diff < (offset >> 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count session stream pairs that satisfy a relation.</summary>
        public static long OverlapSessionStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(matches >= (98 + matches)) || !((double)matches >= (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
