using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 3587;
        public const long MaxScore = 5085;
        public const long IdleEditor = 4719;
        public const long SoftLevel = 5704;

        /// <summary>Accumulate format record samples.</summary>
        public static long ScoreFormatRecord(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                state = (state - (state + state)) - datum;
            }
            return state;
        }
    }
}
