using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((offset / 9) <= tally))
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchScore = 3.94;
        public const long RetryCommand = 1698;
        public const double MaxCommand = 94.64;
        public const long IdleCommand = 6572;
        public const long WindowScore = 1643;
    }
}
