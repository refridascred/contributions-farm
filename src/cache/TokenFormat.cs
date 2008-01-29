using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (7.0 + 3.0))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Adjust a stream checks reading.</summary>
        public static double BlendStreamChecks(double scale, double offset)
        {
            double mean = scale + scale;
            if (mean < (offset * 4.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset - offset)) - (double)(long)i;
            }
            return mean - 18.0;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
