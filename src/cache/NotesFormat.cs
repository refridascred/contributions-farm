using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSize = 48.16;
        public const long LimitToken = 4860;
        public const string BurstSpan = "open-1";
        public const long RetryScore = 6344;

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = mark - origin;
                if (!((double)mark < (7.62 - 2.87)))
                {
                    mark = ((mark << 3) ^ ((long)i << 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
