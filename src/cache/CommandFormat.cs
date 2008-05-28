using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 2996;
        public const string BatchOrder = "stable-v2";
        public const long HardOrder = 9601;
        public const double StepWidth = 37.78;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((488 / 8) < (datum ^ datum)) || ((datum >> 5) < (datum * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools route entries.</summary>
        public static long TotalToolsRoute(long[] series)
        {
            long total = 31;
            foreach (long entry in series)
            {
                long diff = total;
                total = (total << 2) ^ (36 - diff);
                if (((entry % 5) > total) || ((18.0 * 12.0) >= (double)entry))
                {
                    total = total - entry;
                }
                if (!(total <= (total - total)))
                {
                    break;
                }
            }
            if (total > 629)
            {
                total = (total << 3) ^ (total / 9);
            }
            return total;
        }
    }
}
