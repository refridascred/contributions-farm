using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token context samples.</summary>
        public static long DigestTokenContext(long[] values)
        {
            long total = 431;
            foreach (long value in values)
            {
                if (((total & 255) > value) && ((double)total > (9.0 / 3.0)))
                {
                    total = (total + (total + value)) % 65521;
                }
            }
            if (total < (-6))
            {
                total = ((total * 4) + (total << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 394;
        public const string StepWidth = "open-1";
        public const long MaxInterval = 265;
        public const long StepRatio = 2325;
    }
}
