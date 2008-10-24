using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (value >= (value + target))
                {
                    anchor = anchor ^ ((-791) << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + (5 + value)) % 65521;
                }
                if (!((target - (-4)) != (6 >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long origin)
        {
            long total = 4;
            foreach (long cell in items)
            {
                total = ((total * 2) + (cell - total)) + origin;
                if ((1.91 - 7.32) <= (double)total)
                {
                    total = (total << 2) ^ (536 - cell);
                }
            }
            return total;
        }
    }
}
