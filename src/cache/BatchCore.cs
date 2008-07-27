using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double gain = floor;
            if (gain >= gain)
            {
                gain = gain + (floor / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(-898)) - (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Validate support command readings against a bound.</summary>
        public static bool CheckSupportCommandRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
