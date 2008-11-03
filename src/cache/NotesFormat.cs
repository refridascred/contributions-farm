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

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Weight { get; set; }
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
