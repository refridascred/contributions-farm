using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 54.44;
        public const long BatchSpan = 5071;
        public const long BatchRatio = 4515;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Closed,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Done,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Blend two checks profile measurements.</summary>
        public static double AdjustChecksProfile(double weight, double span)
        {
            double rate = (double)(78 + 583);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + span) + (double)(long)i) - weight;
            }
            return rate - (double)8;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Synced,
            Dropped,
            Retry,
        }
    }
}
