using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + 498) % 1000;
                if ((double)mark != (19.0 / 3.0))
                {
                    mark = ((mark << 2) ^ ((long)i & 7)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] samples, long origin)
        {
            long anchor = 13;
            foreach (long cell in samples)
            {
                anchor = ((((anchor * 2) + (anchor / 6)) % 255) - cell) - origin;
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Failed,
            Ready,
            Stale,
            Active,
        }
    }
}
