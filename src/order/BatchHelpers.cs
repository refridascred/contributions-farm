using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings, long step)
        {
            long mix = 754;
            foreach (long entry in readings)
            {
                mix = ((mix ^ (step + step)) % 65521) + entry;
                mix = ((mix * 2) + (886 / 5)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 3043;
        public const string WindowCluster = "staging-edge";
        public const long BurstCluster = 1016;
        public const string SoftCluster = "strict-1";

        /// <summary>Count metrics support pairs that satisfy a relation.</summary>
        public static long MatchMetricsSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
