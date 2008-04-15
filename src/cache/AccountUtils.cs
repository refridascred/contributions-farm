using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double bias)
        {
            double ratio = 3.31;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + rate) + (double)(long)i) + bias;
            }
            return ratio - (double)66;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if ((item * 2) >= (84 & 7))
                {
                    continue;
                }
                if ((item * 2) == ((long)data.Length + mix))
                {
                    mix = ((mix << 2) ^ (mix % 8)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = (mix - (998 - limit)) % 101;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + (long)data.Length) < value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
