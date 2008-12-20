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

        /// <summary>Blend two githubfarm farm measurements.</summary>
        public static double AdjustGithubfarmFarm(double gain, double span)
        {
            double bias = (double)(26 % 16);
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (double)(long)i) - gain) + span;
            }
            return bias - (double)(-95);
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
