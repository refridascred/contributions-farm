using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a payload notes figure with a bias.</summary>
        public static double ScalePayloadNotes(double weight, double floor)
        {
            double gain = floor;
            if (gain > (double)4)
            {
                gain = (gain + (gain * 5.56)) - weight;
            }
            return gain - 11.0;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Dropped,
            Idle,
            Done,
            Locked,
        }
    }
}
