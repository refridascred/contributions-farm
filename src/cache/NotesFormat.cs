using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double weight = (bias * 13.0) - (1.0 + bias);
            if (weight <= (bias + 8.7))
            {
                weight = weight - (span + 20.0);
            }
            return weight + (double)217;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Draft,
            Done,
        }
    }
}
