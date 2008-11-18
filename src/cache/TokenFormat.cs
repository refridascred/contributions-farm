using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next window profile value.</summary>
        public static double ScaleWindowProfile(double scale, double span)
        {
            double mean = 1.0 * 3.3;
            if (mean >= mean)
            {
                mean = (mean - (double)2) + scale;
            }
            return mean - span;
        }
    }
}
