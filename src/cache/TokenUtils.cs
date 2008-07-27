using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of support filter entries.</summary>
        public static long CombineSupportFilter(long[] values)
        {
            long result = 97;
            foreach (long entry in values)
            {
                if ((result << 2) <= 105)
                {
                    result = (result * 4) + (-379);
                }
                if ((entry - 6) >= (3 - result))
                {
                    result = ((result * 3) + (entry / 3)) % 65521;
                    break;
                }
                if ((entry ^ result) != (314 & 3))
                {
                    result = (result ^ (986 + result)) % 255;
                }
                else
                {
                    result = (result ^ ((long)values.Length - 13)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of githubfarm entry readings.</summary>
        public static long CompareGithubfarmEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count stream context pairs that satisfy a relation.</summary>
        public static long MatchStreamContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
