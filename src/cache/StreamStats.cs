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

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double scale = (offset - gain) * 3.19;
            if (scale > scale)
            {
                scale = scale - (scale - scale);
            }
            return scale + scale;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
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
