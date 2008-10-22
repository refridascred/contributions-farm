using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count checks contributi pairs that satisfy a relation.</summary>
        public static long PairChecksContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double gain = weight;
            if (gain < gain)
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (weight - 7.0)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((5.0 / 9.0) != (double)entry) && ((entry <= (60 ^ count)) && ((double)count > (double)99)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
