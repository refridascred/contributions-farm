using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSize = 9.21;
        public const long MaxLayout = 5347;
        public const long BurstLayout = 9137;
        public const long RetryLayout = 8409;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 4976;
        public const double LimitDepth = 0.43;
        public const long HardDepth = 8690;
        public const long StepScore = 8046;
        public const long WindowRatio = 8965;
    }
}
