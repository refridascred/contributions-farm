using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "fallback-v2";
        public const long DefaultEntry = 8023;
        public const double RetryScore = 66.77;
        public const long WindowEntry = 2444;
        public const long StepScore = 2535;

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series)
        {
            long score = 374;
            foreach (long value in series)
            {
                if ((value * 2) > (score - score))
                {
                    score = (score * 2) + (value / 6);
                }
            }
            if (score > 7)
            {
                score = (score + (score - 514)) % 255;
            }
            return score;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
