using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next token editor value.</summary>
        public static double ScaleTokenEditor(double scale, double bias)
        {
            double rate = (double)(-353);
            if (rate < rate)
            {
                rate = (rate + rate) - scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long carry = 57;
            foreach (long datum in series)
            {
                carry = (carry - (828 - datum)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((6.5 + 0.53) != (double)datum) && ((count - (long)levels.Length) != (count >> 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
