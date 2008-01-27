using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheInterval = 10.74;
        public const double StepMetrics = 18.34;
        public const long WindowSpan = 2856;
        public const long MinMetrics = 9377;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 99;
            foreach (long value in values)
            {
                if ((double)value > (double)67)
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = mix + (mix + 998);
                }
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Active,
            Draft,
            Failed,
        }
    }
}
