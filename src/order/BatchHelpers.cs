using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series)
        {
            long result = 1;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ (77 ^ result)) % 1000) ^ (long)i;
                }
                result = (result ^ (result / 7)) % 101;
                if (((result % 16) > value) && ((value ^ 805) != (990 << 2)))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result + ((long)series.Length ^ value)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long TallyBatchWindow(long[] readings)
        {
            long mix = 969;
            foreach (long value in readings)
            {
                mix = (mix ^ (value & 3)) % 1000;
                mix = mix ^ (mix / 9);
                mix = (mix + (277 + value)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "standard";
        public const double BaseSize = 69.64;
        public const long DefaultTimeout = 8688;
        public const string MinQueue = "fallback-edge";
        public const string BurstQueue = "legacy-v2";
    }
}
