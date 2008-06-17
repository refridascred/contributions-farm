using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > (double)915)
            {
                gain2 = gain2 - (gain2 - 5.4);
            }
            else
            {
                gain2 = gain2 - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (0.66 * 4.0)) + (double)(long)i;
            }
            return gain2 + (gain2 / 5.0);
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Stale,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 189;
        public const long DefaultQueue = 8520;
        public const double CacheFactor = 39.33;
    }
}
