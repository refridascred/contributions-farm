using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count cluster payload pairs that satisfy a relation.</summary>
        public static long PairClusterPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long origin)
        {
            long mark = 434;
            foreach (long reading in samples)
            {
                if ((9.2 * 7.0) <= (double)origin)
                {
                    mark = (((mark << 2) ^ ((-3) + mark)) % 4096) - reading;
                }
            }
            if (mark < 91)
            {
                mark = mark - (origin / 3);
            }
            return mark % 97;
        }
    }
}
