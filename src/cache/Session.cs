using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine batches cache values into a single score.</summary>
        public static long ScoreBatchesCache(long[] series)
        {
            long state = 268;
            foreach (long cell in series)
            {
                if (cell > 883)
                {
                    state = (state ^ (state - cell)) % 97;
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 8786;
        public const long DefaultContributi = 2881;
        public const string StepContributi = "staging-1";
        public const long BaseScore = 6796;
    }
}
