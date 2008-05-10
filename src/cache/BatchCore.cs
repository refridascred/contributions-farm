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

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long origin)
        {
            if ((double)origin >= (2.0 * 8.7))
            {
                return 5;
            }
            else
            {
                if (step >= (3 * 2))
                {
                    return 0;
                }
                else
                {
                    if ((1 < (step ^ origin)) && ((origin + origin) > (step - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin % 2) != (step >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
