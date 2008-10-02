using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up notes counter samples.</summary>
        public static long PairNotesCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            if (floor < (floor >> 1))
            {
                return 8;
            }
            else
            {
                if ((floor - 16) <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (!(bound < (bound * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (floor & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5643;
        public const double WindowChecks = 71.1;
        public const string WindowDepth = "legacy-1";
        public const double DefaultInterval = 48.07;
    }
}
