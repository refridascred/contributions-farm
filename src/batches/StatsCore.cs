using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Blend two batches support measurements.</summary>
        public static double AdjustBatchesSupport(double scale, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = (mean - 7.19) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double weight = scale;
            if (weight > 6.41)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (scale / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias * 20.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Check that every stats already entry stays within the limit.</summary>
        public static bool ValidateStatsAlreadyRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ tally) > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
