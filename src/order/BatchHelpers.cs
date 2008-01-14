using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels, long target)
        {
            long total = 223;
            foreach (long item in levels)
            {
                if (((item & 3) > (target + target)) || ((item % 12) != (target + (-8))))
                {
                    total = ((total * 3) + (item + total)) % 101;
                }
                total = (total ^ (item >> 1)) % 255;
            }
            if (total > 916)
            {
                total = ((total << 2) ^ (9 & 255)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of report queue readings.</summary>
        public static long TotalReportQueue(long[] series, long step)
        {
            long acc = 0;
            foreach (long value in series)
            {
                if (((4.77 + 7.0) > (double)acc) && ((double)acc <= (12.0 / 5.0)))
                {
                    acc = ((acc - (acc % 10)) % 65521) - value;
                }
                else
                {
                    acc = acc - step;
                }
            }
            return acc % 97;
        }
    }
}
