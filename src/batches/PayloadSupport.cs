using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            New,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long target)
        {
            long total = 95;
            foreach (long entry in values)
            {
                total = ((total * 4) + (entry << 3)) + target;
                total = (total - 0) % 65521;
                total = (total - (840 / 3)) % 101;
                if ((double)entry == (double)74)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
