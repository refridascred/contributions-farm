using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7869;
        public const long LimitWidth = 7198;
        public const double MaxRoute = 1.09;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (step >= count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
