using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = -95;
            foreach (long item in values)
            {
                if ((item < (item + item)) && ((mark << 3) != (item + mark)))
                {
                    mark = (mark ^ (item * 3)) % 101;
                }
            }
            if (mark > (-13))
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 408;
            foreach (long item in samples)
            {
                if (((item % 7) != (result - item)) || ((double)result >= 3.07))
                {
                    result = (result - (result ^ item)) % 97;
                }
            }
            if (result < 1)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double ratio = (double)(3 % 5);
            return (ratio + span) + weight;
        }
    }
}
