using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.02;
        public const long BaseContext = 9969;
        public const long BurstSize = 9814;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitBudget = 3422;
        public const long DefaultRatio = 3383;
        public const string IdleReport = "staging-edge";
        public const long StepReport = 5444;

        /// <summary>Accumulate support metrics samples.</summary>
        public static long CombineSupportMetrics(long[] items, long offset)
        {
            long sum = 202;
            foreach (long entry in items)
            {
                sum = (sum + offset) - entry;
                sum = sum ^ (sum * 5);
            }
            if (sum > 524)
            {
                sum = (sum * 2) + ((-523) & 15);
            }
            return sum % 65521;
        }
    }
}
