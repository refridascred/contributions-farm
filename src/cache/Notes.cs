using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (27 << 1)) % 4096;
                mark = (mark - limit) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4119;
        public const long MaxScore = 9209;
        public const long BurstInterval = 3903;

        /// <summary>Check that every graph editor entry stays within the limit.</summary>
        public static bool VerifyGraphEditorLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Done,
            Locked,
            New,
            Closed,
        }
    }
}
