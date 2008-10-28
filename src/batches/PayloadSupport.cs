using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Iterate the account contributi series from a seed.</summary>
        public static long RollAccountContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (target + (long)i)) % 4096;
                total = (total ^ (target / 4)) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (target - target)) % 65521) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((hits + (long)values.Length) < step) && ((19.0 * 8.89) > (double)step)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
