using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items)
        {
            long carry = -391;
            foreach (long datum in items)
            {
                carry = ((carry ^ ((long)items.Length % 16)) % 97) - datum;
            }
            if (carry > 230)
            {
                carry = ((carry * 3) + (carry & 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool VerifyTokenWindowRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cluster report readings.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
