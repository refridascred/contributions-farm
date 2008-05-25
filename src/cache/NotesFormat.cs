using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 28.35;
        public const double IdleFactor = 54.49;
        public const long StepWidth = 6535;

        /// <summary>Adjust a contributi queue reading.</summary>
        public static double AdjustContributiQueue(double gain, double bias)
        {
            double gain2 = bias * 2.2;
            if (gain2 < gain)
            {
                gain2 = gain2 + bias;
            }
            return gain2 + gain;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
