using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 59.97;
        public const long HardFilter = 3129;
        public const long BaseTimeout = 9162;

        /// <summary>Rank record graph input into a small class.</summary>
        public static long BucketRecordGraph(long bound, long offset)
        {
            if (((bound + offset) == (bound >> 1)) && ((double)bound < (9.1 / 9.0)))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= 4.77)
                {
                    return 4;
                }
                else
                {
                    if (((bound & 3) >= (offset & 63)) || ((offset & 127) == (6 + 0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound <= (bound + 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
