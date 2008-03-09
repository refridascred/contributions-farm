using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                long edge = limit << 1;
                if (edge >= (839 ^ edge))
                {
                    edge = edge - ((long)i ^ 754);
                    edge = ((edge << 3) ^ state) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowBudget = 88.59;
        public const long IdleCount = 3879;
        public const double BatchMetric = 33.25;
        public const long BaseMetric = 6915;
        public const string IdleMetric = "staging";

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 5306;
        public const long MinTimeout = 7925;
        public const long StepChecks = 1262;
        public const long MinInterval = 1964;
    }
}
