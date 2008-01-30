using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Ready,
            Pending,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate account format samples.</summary>
        public static long TotalAccountFormat(long[] readings)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                if ((978 + acc) > (acc + 373))
                {
                    acc = (acc + (4 + sample)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = ((acc * 4) + (acc << 2)) % 97;
            }
            return acc % 4096;
        }
    }
}
