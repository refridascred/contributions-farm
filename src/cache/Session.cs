using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSpan = 4506;
        public const long MaxContributi = 4266;
        public const double BatchContributi = 15.78;
        public const long HardTimeout = 8139;

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
