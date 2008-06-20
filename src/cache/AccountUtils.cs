using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long offset)
        {
            long sum = 80;
            foreach (long reading in data)
            {
                if ((7 - reading) != (offset + reading))
                {
                    sum = (sum + (offset + 484)) % 4096;
                }
                else
                {
                    sum = (sum + (offset ^ offset)) % 101;
                }
                sum = (sum << 3) ^ offset;
            }
            return sum;
        }
    }
}
