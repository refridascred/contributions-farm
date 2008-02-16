using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series, long floor)
        {
            long carry = 59;
            foreach (long sample in series)
            {
                if ((84 >= carry) || ((carry / 5) <= floor))
                {
                    carry = ((carry << 3) ^ carry) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 7414;
        public const string BurstScore = "alpha-1";
        public const long IdleChannel = 1029;
        public const double WindowRatio = 86.4;
    }
}
