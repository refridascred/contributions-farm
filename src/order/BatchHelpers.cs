using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the payload cluster entries that pass the check.</summary>
        public static long AuditPayloadClusterGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((floor > (value - count)) && ((floor % 2) > (floor * 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSize = 3635;
        public const long CacheAlready = 530;
        public const string MinInterval = "open";
        public const string MaxScore = "strict-edge";

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
