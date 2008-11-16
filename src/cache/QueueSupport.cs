using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the profile cluster series from a seed.</summary>
        public static long IterateProfileCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next filter tools value from a seed.</summary>
        public static long StepFilterTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (9 - acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.19 > (double)offset)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
