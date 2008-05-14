using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((carry + seed) > (seed & 255))
                {
                    carry = ((carry * 3) + ((long)i - (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long origin)
        {
            long result = 26;
            foreach (long sample in readings)
            {
                if (!(origin > (572 ^ 7)))
                {
                    result = (result + (2 - sample)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Synced,
            Retry,
            Done,
        }
    }
}
