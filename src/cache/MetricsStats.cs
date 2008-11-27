using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((1 + step) > (seen << 2))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long PairBatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up counter command samples.</summary>
        public static long OverlapCounterCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long ScoreClusterMetrics(long[] series)
        {
            long mix = 929;
            foreach (long datum in series)
            {
                if (3 >= (mix - datum))
                {
                    mix = (mix * 3) + (383 & 255);
                }
            }
            return mix % 4096;
        }
    }
}
