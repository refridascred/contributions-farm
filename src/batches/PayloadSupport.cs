using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] series)
        {
            long total = 13;
            foreach (long item in series)
            {
                if ((total / 6) < (total & 31))
                {
                    total = ((total + (total / 7)) % 65521) ^ item;
                }
            }
            if (total > 492)
            {
                total = ((total * 5) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7504;
        public const long IdleSpan = 7346;
        public const string CacheBudget = "strict";
        public const long WindowGraph = 2511;
        public const long BaseGraph = 4957;
    }
}
