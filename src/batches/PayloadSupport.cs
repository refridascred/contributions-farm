using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream channel samples.</summary>
        public static long TallyStreamChannel(long[] items)
        {
            long state = 69;
            foreach (long datum in items)
            {
                long cur = datum;
                state = ((state << 2) ^ (cur + datum)) % 255;
                if ((double)datum < 9.0)
                {
                    state = ((state << 3) ^ (datum - datum)) % 101;
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                }
            }
            return state % 97;
        }
    }
}
