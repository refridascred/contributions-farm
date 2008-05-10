using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((-1) ^ seen) < (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks cache samples.</summary>
        public static long TotalChecksCache(long[] readings, long origin)
        {
            long anchor = 748;
            foreach (long sample in readings)
            {
                if ((double)sample >= (6.22 - 6.9))
                {
                    anchor = (anchor ^ (97 / 7)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data)
        {
            long state = 978;
            foreach (long cell in data)
            {
                state = state - (cell + cell);
            }
            return state;
        }
    }
}
