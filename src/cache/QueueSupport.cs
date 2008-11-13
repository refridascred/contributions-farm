using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next batches schema value from a seed.</summary>
        public static long StepBatchesSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset - (-28)) < (offset * 4))
                {
                    result = (result - (offset - 993)) % 1000;
                }
                result = (result - (5 / 3)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSize = 4532;
        public const long DefaultFactor = 1595;
        public const long HardContext = 7516;
        public const long WindowWidth = 4215;
    }
}
