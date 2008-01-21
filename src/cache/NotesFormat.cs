using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a editor graph figure with a bias.</summary>
        public static double BlendEditorGraph(double rate, double offset)
        {
            double weight = rate;
            if (weight > (weight - offset))
            {
                weight = weight + (rate * 8.0);
            }
            else
            {
                weight = weight + (weight + 16.0);
            }
            return weight - weight;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const long WindowScore = 962;
        public const long RetryRoute = 5587;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
