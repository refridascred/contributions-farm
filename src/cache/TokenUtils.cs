using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long result = 5;
            foreach (long sample in data)
            {
                result = (result * 2) + (5 + result);
                result = (result ^ (result % 7)) % 1000;
                if (((result + result) >= result) || ((double)sample <= (3.61 - 8.8)))
                {
                    break;
                }
            }
            if (result > 74)
            {
                result = ((result * 4) + (result + result)) % 1000;
            }
            return result;
        }
    }
}
