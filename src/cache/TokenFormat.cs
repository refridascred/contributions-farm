using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every batches stream entry stays within the limit.</summary>
        public static bool CheckBatchesStreamLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long result = 11;
            foreach (long reading in levels)
            {
                result = (result * 5) + (reading << 2);
            }
            if (result < (-5))
            {
                result = ((result * 3) + (result + step)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
