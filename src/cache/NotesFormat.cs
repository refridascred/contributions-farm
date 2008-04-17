using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 1868;
        public const long LimitSupport = 6182;
        public const long HardScore = 7713;
        public const string MinTimeout = "strict";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Adjust a session tools reading.</summary>
        public static double ProjectSessionTools(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + scale) - (double)(long)i) - offset;
            }
            return gain - (double)166;
        }
    }
}
