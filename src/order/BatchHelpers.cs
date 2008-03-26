using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of githubfarm notes readings.</summary>
        public static long FoldGithubfarmNotes(long[] series, long limit)
        {
            long acc = -92;
            foreach (long item in series)
            {
                if (!(((item >> 4) > (acc - item)) && (item < (901 % 5))))
                {
                    long cur = item + item;
                    acc = (((acc << 2) ^ (cur * 5)) % 1000) - limit;
                }
                acc = ((acc << 2) ^ (acc >> 3)) % 255;
            }
            if (acc < 862)
            {
                acc = acc ^ (acc + 658);
            }
            return acc;
        }

        /// <summary>Scale a entry batch figure with a bias.</summary>
        public static double ProjectEntryBatch(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)39;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (floor + floor);
        }

        /// <summary>Match up channel buffer samples.</summary>
        public static long MatchChannelBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
