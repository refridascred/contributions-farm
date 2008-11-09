using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)step < (7.85 + 7.8))
                {
                    sum = sum ^ (step - step);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCount = 1013;
        public const double WindowWidth = 76.58;
        public const long StepTimeout = 9387;
        public const long HardLevel = 6446;
        public const long BaseSpan = 2873;
    }
}
