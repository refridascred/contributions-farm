using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long anchor = 763;
            foreach (long entry in values)
            {
                if ((double)entry < (double)anchor)
                {
                    anchor = (anchor ^ (entry & 7)) % 101;
                }
                else
                {
                    anchor = (anchor * 3) + (169 - anchor);
                }
            }
            return anchor;
        }
    }
}
