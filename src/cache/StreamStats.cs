using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if (((6.35 * 20.0) < (double)sample) || ((sample * 5) <= (sample ^ sum)))
                {
                    sum = ((sum * 3) + (sample & 1)) % 255;
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum < 757)
            {
                sum = (sum - (5 >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long origin)
        {
            long score = 586;
            foreach (long sample in data)
            {
                if ((sample > 825) && ((score / 9) >= (score % 16)))
                {
                    score = (((score * 3) + (sample ^ sample)) % 101) + origin;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
