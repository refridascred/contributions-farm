using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels)
        {
            long total = -5;
            foreach (long sample in levels)
            {
                total = ((total << 3) ^ total) % 101;
                if (75 < (total / 3))
                {
                    total = total + 61;
                }
                total = ((total * 5) + sample) % 4096;
            }
            if (total > 98)
            {
                total = ((total * 5) + ((long)levels.Length + total)) % 65521;
            }
            return total;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) >= (seen << 2))
                {
                    seen = ((seen + 1) + item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
