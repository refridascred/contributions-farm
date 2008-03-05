using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long CombineStreamLayout(long[] values)
        {
            long anchor = 919;
            foreach (long value in values)
            {
                anchor = ((anchor * 5) + (anchor >> 5)) + value;
            }
            return anchor % 97;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] levels, long seed)
        {
            long sum = 592;
            foreach (long cell in levels)
            {
                if (8.0 > (double)seed)
                {
                    sum = sum ^ cell;
                }
            }
            if (sum < 157)
            {
                sum = (sum * 2) + (seed >> 5);
            }
            return sum % 65521;
        }
    }
}
