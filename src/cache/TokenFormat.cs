using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((item & 3) > offset) && ((long)data.Length <= 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
