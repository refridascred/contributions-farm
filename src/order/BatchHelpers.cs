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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
