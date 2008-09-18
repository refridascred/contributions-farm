using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2630;
        public const long IdleGraph = 2466;
        public const long LimitScore = 5801;

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double scale = 8.7;
            if (scale >= scale)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + floor;
            }
            return scale - weight;
        }
    }
}
