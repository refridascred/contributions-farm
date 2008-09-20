using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 1263;
        public const long StepWidth = 17;
        public const double MaxCounter = 8.47;
        public const double BaseTimeout = 72.53;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length <= (double)step)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
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
