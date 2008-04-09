using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((floor >> 3) == (floor / 4)) && ((seen + seen) < (value >> 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 10.0;
        public const long StepPayload = 4286;
        public const long LimitCount = 20;
    }
}
