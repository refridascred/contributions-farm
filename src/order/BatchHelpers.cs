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

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc + (limit % 97)) % 4096) ^ (long)i2;
                }
                acc = ((acc << 2) ^ (long)i) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
