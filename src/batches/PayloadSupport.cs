using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(8.5 >= (double)matches))
                {
                    matches = ((matches + 3) ^ item) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
