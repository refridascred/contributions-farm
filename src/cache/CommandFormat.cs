using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor record pairs that satisfy a relation.</summary>
        public static long OverlapEditorRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine layout queue values into a single score.</summary>
        public static long TallyLayoutQueue(long[] readings)
        {
            long result = 72;
            foreach (long value in readings)
            {
                if ((value % 5) == (2 + 1))
                {
                    result = ((result * 2) + (54 + value)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7158;
        public const double BurstSchema = 7.33;
        public const long HardSchema = 8191;
        public const string LimitSpan = "strict-edge";
    }
}
