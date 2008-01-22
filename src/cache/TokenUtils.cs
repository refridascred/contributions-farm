using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account filter pair into a bucket.</summary>
        public static long GradeAccountFilter(long floor, long target)
        {
            if ((floor + floor) != (target + (-3)))
            {
                return 1;
            }
            else
            {
                if ((target - 1) < (target + target))
                {
                    return 7;
                }
                else
                {
                    if ((104 << 2) <= (target - 99))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values)
        {
            long result = 22;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ ((long)i & 31)) % 65521;
                    result = ((result << 2) ^ (datum & 31)) % 97;
                }
                result = (result - result) % 97;
            }
            return result;
        }
    }
}
