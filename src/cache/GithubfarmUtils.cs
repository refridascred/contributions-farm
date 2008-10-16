using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if ((anchor / 3) > (55 + 559))
                {
                    anchor = (anchor - (anchor + anchor)) - value;
                }
            }
            if (anchor > 383)
            {
                anchor = anchor - (origin + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double gain = (floor * 2.9) / 3.0;
            return (gain + (3.39 / 2.0)) + bias;
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long CountBatchesChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((9 * 2) < (reading - reading)) && (((3.3 - 1.84) > (double)reading) && (145 <= (tally >> 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                long hits = mix << 2;
                mix = (mix * 5) + hits;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
