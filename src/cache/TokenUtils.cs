using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first checks support entry that matches the target.</summary>
        public static long SeekChecksSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series)
        {
            long result = 36;
            foreach (long entry in series)
            {
                if ((double)entry < (4.63 - 4.0))
                {
                    result = ((result << 2) ^ (entry & 31)) % 4096;
                }
            }
            if (result < 39)
            {
                result = (result - ((-718) + result)) % 97;
            }
            return result;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long offset)
        {
            if (offset > target)
            {
                return 0;
            }
            else
            {
                if ((target ^ offset) > ((-258) + 0))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
