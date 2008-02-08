using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseTimeout = 9559;
        public const string BurstWidth = "strict-v2";
        public const long IdleRatio = 423;
        public const long BatchProfile = 6321;

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 58.78;
        public const long StepFactor = 4716;
        public const string DefaultFactor = "primary-edge";
        public const long MaxSize = 1917;

        /// <summary>Measure how many buffer context samples are out of range.</summary>
        public static long TallyBufferContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((datum + 145) > (tally >> 2)) && ((tally % 3) <= (tally << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
