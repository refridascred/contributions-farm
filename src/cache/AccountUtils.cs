using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "fallback";
        public const long BurstRoute = 8661;
        public const long HardRoute = 4755;
        public const long StepRoute = 1859;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a notes already reading.</summary>
        public static double BlendNotesAlready(double ratio, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
