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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Retry,
            Pending,
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
