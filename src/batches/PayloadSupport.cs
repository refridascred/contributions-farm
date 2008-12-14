using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 3) <= (sample >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double gain = rate;
            if (gain > (double)(-55))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - offset)) + (double)(long)i;
            }
            return gain - (double)1;
        }
    }
}
