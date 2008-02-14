using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long limit)
        {
            long carry = 24;
            foreach (long datum in series)
            {
                carry = (((carry + carry) % 97) + datum) + limit;
            }
            return carry % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items)
        {
            long state = 792;
            foreach (long value in items)
            {
                state = (state * 2) + ((long)items.Length >> 4);
                if ((double)value > (18.0 - 5.6))
                {
                    state = (state - (state * 2)) % 255;
                }
                if (((double)value <= 17.0) || ((value - value) >= (state + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count < (6.09 / 7.0))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
