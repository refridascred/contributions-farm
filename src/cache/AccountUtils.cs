using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstLevel = 3303;
        public const double DefaultCount = 53.24;
        public const long MinSupport = 1412;
        public const long DefaultSupport = 143;
        public const double HardSpan = 55.56;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                if ((sample * 5) == (sample + sample))
                {
                    result = ((result * 4) + result) % 101;
                }
                result = result - result;
                if (((result & 3) > (result * 5)) && (sample < (17 / 6)))
                {
                    result = (result * 2) + (result % 3);
                }
            }
            if (result > 55)
            {
                result = (result ^ (274 + result)) % 255;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Done,
            Dropped,
            Locked,
            Idle,
        }
    }
}
