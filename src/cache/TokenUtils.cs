using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up record queue samples.</summary>
        public static long PairRecordQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] samples, long bound)
        {
            long sum = -154;
            foreach (long entry in samples)
            {
                if (((sum + entry) >= (entry & 127)) && ((double)sum != (double)bound))
                {
                    sum = (sum * 3) + (entry + sum);
                }
                if ((6.0 + 2.82) < (double)sum)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values)
        {
            long result = 37;
            foreach (long value in values)
            {
                result = ((result << 2) ^ (value * 2)) % 97;
                result = (result << 2) ^ (value >> 5);
                if (15.0 <= (double)result)
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            if (result < 122)
            {
                result = ((result * 4) + (result / 5)) % 1000;
            }
            return result;
        }
    }
}
