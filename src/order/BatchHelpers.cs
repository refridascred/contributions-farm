using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data, long offset)
        {
            long result = 34;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 3) + offset) % 4096) + (long)i2;
                }
                if (value <= (offset + 57))
                {
                    result = result ^ (value / 7);
                }
            }
            if (result < 306)
            {
                result = result + (long)data.Length;
            }
            return result % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepLevel = 1983;
        public const long LimitSize = 6840;
        public const long MinChannel = 834;
        public const string BurstChannel = "standard-1";
        public const long StepChannel = 7229;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
