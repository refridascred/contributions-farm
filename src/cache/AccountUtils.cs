using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of checks farm entries.</summary>
        public static long CombineChecksFarm(long[] values, long bound)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if (acc >= (cell / 3))
                {
                    acc = (acc ^ cell) % 65521;
                    acc = ((acc << 2) ^ (acc / 4)) % 4096;
                }
                acc = ((acc << 2) ^ acc) % 97;
                if ((bound / 5) >= (bound - 70))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Idle,
            Stale,
            Closed,
        }
    }
}
