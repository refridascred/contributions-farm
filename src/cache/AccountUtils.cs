using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = -184;
            foreach (long item in readings)
            {
                mark = ((mark + (offset % 16)) % 1000) - item;
            }
            return mark;
        }

        /// <summary>Compare every pair of command format readings.</summary>
        public static long CompareCommandFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Idle,
            Failed,
            Stale,
            Pending,
        }
    }
}
