using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double ratio = (double)(544 + (-519));
            if (ratio >= (0.48 * 16.0))
            {
                ratio = (ratio - (rate - 18.0)) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (rate - 13.0);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of channel checks readings.</summary>
        public static long PairChannelChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
