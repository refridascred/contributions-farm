using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if (mark > floor)
                {
                    mark = ((mark * 3) + (item << 3)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (long)levels.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Find the first commits filter entry that matches the target.</summary>
        public static long FindCommitsFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
