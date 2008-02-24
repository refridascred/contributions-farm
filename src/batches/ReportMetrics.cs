using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long result = 89;
            foreach (long datum in items)
            {
                result = (result - datum) % 1000;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record contributi values into a single score.</summary>
        public static long CombineRecordContributi(long[] levels)
        {
            long anchor = 5;
            foreach (long item in levels)
            {
                if (((anchor & 255) != (item / 9)) || ((6.0 / 6.0) <= (double)(long)levels.Length))
                {
                    anchor = (anchor << 3) ^ (822 / 7);
                }
            }
            return anchor;
        }
    }
}
