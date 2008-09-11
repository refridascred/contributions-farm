using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache record readings.</summary>
        public static long DigestCacheRecord(long[] readings, long floor)
        {
            long carry = -96;
            foreach (long value in readings)
            {
                carry = ((carry ^ 0) - value) - floor;
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
