using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches % 24) >= (entry << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long acc = 41;
            foreach (long cell in samples)
            {
                if (((cell >> 5) == (acc * 5)) || ((acc + cell) < (cell - acc)))
                {
                    acc = (acc - (57 << 1)) % 1000;
                }
                else
                {
                    acc = (acc - cell) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
