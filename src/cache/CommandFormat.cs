using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) <= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (long)i;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum - (long)i2;
                    sum = ((sum << 2) ^ ((long)i2 ^ floor)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
