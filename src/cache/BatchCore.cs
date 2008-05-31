using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples)
        {
            long acc = 834;
            foreach (long cell in samples)
            {
                if (((-7) % 60) < (cell ^ cell))
                {
                    break;
                }
                else
                {
                    acc = (acc ^ acc) % 255;
                }
                if ((cell + cell) > (long)samples.Length)
                {
                    acc = (acc ^ (cell & 7)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ cell) % 101;
                }
                acc = acc + cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6265;
        public const long CacheSupport = 278;
        public const long IdleRatio = 2373;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Ready,
            Active,
            Locked,
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (402 <= (count - seed))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
