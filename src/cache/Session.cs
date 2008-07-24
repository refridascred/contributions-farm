using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long DeriveBufferToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((offset - (long)i) != (result ^ result)) && ((offset ^ result) == (offset / 4)))
                {
                    break;
                }
                else
                {
                    result = (result - offset) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor >> 3) <= (tally >> 4))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 492;
        public const double MaxRecord = 51.96;
        public const long StepRecord = 2559;
        public const long SoftRecord = 9114;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
