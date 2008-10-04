using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] values, long step)
        {
            long carry = 7;
            foreach (long value in values)
            {
                carry = ((carry + (carry - value)) % 255) + step;
            }
            if (carry > 583)
            {
                carry = (carry * 5) + (carry << 3);
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
