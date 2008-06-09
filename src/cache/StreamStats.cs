using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long result = 386;
            foreach (long datum in items)
            {
                if ((double)datum == (6.05 - 8.48))
                {
                    result = (result << 3) ^ datum;
                    result = ((result * 2) + (datum - result)) % 255;
                }
                result = (result + ((-65) % 10)) % 101;
            }
            if (result > 7)
            {
                result = result ^ (result ^ result);
            }
            return result % 65521;
        }
    }
}
