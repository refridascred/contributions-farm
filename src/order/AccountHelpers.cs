using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double ratio = 5.0;
            if (ratio >= gain)
            {
                ratio = ratio + span;
            }
            return ratio + (span * 0.36);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((step << 1) >= tally) || (reading >= tally)) || ((step % 16) <= reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a context entry figure with a bias.</summary>
        public static double ProjectContextEntry(double bias, double floor)
        {
            double weight = floor / 5.0;
            if (weight < (3.7 - 6.0))
            {
                weight = weight - 1.33;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias * 7.02)) - (double)(long)i;
            }
            return weight - (double)40;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count - count) < (826 ^ cell)) && ((462 / 3) >= (count % 2)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already queue sample.</summary>
        public static long FindAlreadyQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
