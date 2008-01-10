using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter format readings.</summary>
        public static long CombineFilterFormat(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                if ((double)bound != (18.0 / 9.0))
                {
                    anchor = (((anchor << 2) ^ bound) % 4096) + datum;
                }
                else
                {
                    anchor = (anchor ^ (3 % 10)) % 4096;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor - (bound + bound)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
