using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values)
        {
            long mark = 5;
            foreach (long cell in values)
            {
                if ((mark / 5) <= (mark & 63))
                {
                    mark = mark - (mark + 28);
                }
                if (((mark + 97) == (cell & 127)) || ((mark + cell) >= (cell << 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
