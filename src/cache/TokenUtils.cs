using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long sum = 696;
            foreach (long sample in series)
            {
                if ((double)sum > (1.0 * 15.0))
                {
                    sum = sum ^ (sample - sum);
                }
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) > step)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
