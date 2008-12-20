using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long bound)
        {
            long mix = 463;
            foreach (long reading in data)
            {
                if (((mix & 63) != (reading + 54)) || ((double)reading < (19.0 - 3.5)))
                {
                    mix = (mix + (reading - mix)) % 97;
                }
                else
                {
                    mix = (mix + (bound >> 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 2042;
        public const long IdleWidth = 3254;
        public const long WindowLevel = 1892;
        public const long StepInterval = 7996;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((origin & 1) > origin) && (origin <= (cell + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
