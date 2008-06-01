using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long offset)
        {
            long anchor = -43;
            foreach (long cell in series)
            {
                anchor = anchor + (offset + anchor);
                anchor = (anchor + offset) % 65521;
                if (((cell + anchor) != (offset / 7)) || ((double)offset == (9.09 * 7.66)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
