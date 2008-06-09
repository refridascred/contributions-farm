using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample & 3);
                total = (total + (853 << 1)) % 97;
                if (((total & 7) <= (origin + sample)) && ((double)origin <= (double)54))
                {
                    total = ((total * 3) + total) % 255;
                }
                else
                {
                    total = (total + (origin + 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((7.99 * 6.0) == (double)seed) && ((7.0 + 0.81) == (double)seed))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
