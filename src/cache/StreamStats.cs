using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue context values into a single score.</summary>
        public static long ScoreQueueContext(long[] samples, long offset)
        {
            long mark = 17;
            foreach (long value in samples)
            {
                if ((15.0 >= (double)value) || ((mark - offset) == (0 >> 2)))
                {
                    mark = (mark ^ mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
