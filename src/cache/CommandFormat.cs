using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 12.59;
        public const long StepScore = 8968;
        public const double BaseAlready = 7.9;
        public const double RetryDepth = 94.29;
        public const string LimitAlready = "staging-v2";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double gain = offset;
            if (gain <= scale)
            {
                gain = gain + (1.98 + scale);
            }
            return gain + (gain - scale);
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long MatchTokenFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
