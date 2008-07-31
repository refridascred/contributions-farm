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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
