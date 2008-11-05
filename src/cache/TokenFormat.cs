using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                anchor = ((anchor << 2) ^ (cell & 127)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool GuardAlreadyChannelRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a commits graph sample.</summary>
        public static long FindCommitsGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
