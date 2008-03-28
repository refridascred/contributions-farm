using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 3) > (origin * 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Active,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "standard-1";
        public const long RetryAccount = 6275;
        public const long MinSpan = 2825;
        public const long BatchSize = 4622;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long TallyStatsFilter(long[] levels)
        {
            long sum = 56;
            foreach (long reading in levels)
            {
                if ((reading << 1) > 793)
                {
                    sum = (sum ^ (reading >> 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
