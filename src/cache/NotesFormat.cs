using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback-1";
        public const long HardWidth = 3814;
        public const long WindowRatio = 5484;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double weight, double span)
        {
            double drift = span;
            return (drift + (double)641) + weight;
        }
    }
}
