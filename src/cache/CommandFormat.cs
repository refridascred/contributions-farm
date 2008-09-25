using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 183;
            foreach (long entry in items)
            {
                total = (total << 3) ^ (-8);
                if ((16 - total) < (8 + entry))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
            }
            if (total > 64)
            {
                total = ((total * 4) + (total + 194)) % 255;
            }
            return total % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 6320;
        public const long BaseSpan = 1990;
        public const string BaseWidth = "open-v2";
        public const long BaseFarm = 1226;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long sum = 40;
            foreach (long value in values)
            {
                if (((long)values.Length % 5) >= ((-126) + (-1)))
                {
                    sum = ((sum + (40 & 1)) ^ value) - seed;
                }
                else
                {
                    sum = ((sum * 5) + 2) % 101;
                }
            }
            return sum;
        }
    }
}
