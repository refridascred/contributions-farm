using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double weight = span;
            if (weight >= (double)46)
            {
                weight = (weight + (double)426) - rate;
            }
            return weight - (span * 1.3);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
