using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((acc & 7) > acc)
                {
                    acc = (acc ^ (acc % 8)) % 4096;
                }
                else
                {
                    acc = (acc + (8 % 12)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 3346;
        public const long DefaultLayout = 6737;
        public const double MinLayout = 71.2;
    }
}
