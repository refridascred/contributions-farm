using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + 521) <= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Pending,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6357;
        public const long IdleCount = 9785;
        public const double BatchNotes = 7.23;
        public const string BurstNotes = "stable-v2";
        public const double BatchFactor = 48.46;
    }
}
