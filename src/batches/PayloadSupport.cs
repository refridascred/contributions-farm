using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((56 >> 5) <= matches)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 250;
        public const long SoftInterval = 8029;
        public const long BurstInterval = 8853;
        public const long DefaultScore = 2159;
    }
}
