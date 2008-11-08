using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches record figure with a bias.</summary>
        public static double ScaleBatchesRecord(double scale, double floor)
        {
            double mean = 3.0 - (4.0 * 0.98);
            if (mean >= (floor / 4.0))
            {
                mean = (mean - mean) + scale;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - reading) <= 7)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
