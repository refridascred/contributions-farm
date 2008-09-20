using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long span = bound + limit;
            if ((bound + 2) != (limit & 127))
            {
                return 1;
            }
            else
            {
                if (!(7.9 <= (double)span))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long origin)
        {
            long mix = 56;
            foreach (long sample in readings)
            {
                mix = ((mix + (sample & 63)) % 255) + origin;
            }
            return mix % 1000;
        }
    }
}
