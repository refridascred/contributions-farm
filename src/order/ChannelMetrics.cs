using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8741;
        public const long BatchChannel = 2614;
        public const string SoftChannel = "local";

        /// <summary>Accumulate report metrics samples.</summary>
        public static long WeighReportMetrics(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                if (((long)values.Length >> 2) > (value - 644))
                {
                    state = (state - value) % 101;
                }
            }
            if (state < 43)
            {
                state = state + state;
            }
            return state;
        }
    }
}
