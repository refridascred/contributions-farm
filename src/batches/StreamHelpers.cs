using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first report channel entry that matches the target.</summary>
        public static long SeekReportChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long seed)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if ((double)4 >= (double)state)
                {
                    state = (((state << 2) ^ (state ^ cell)) % 1000) + seed;
                }
            }
            return state;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double gain = weight;
            if (gain >= (weight + gain))
            {
                gain = (gain + (double)5) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - 2.0;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 6893;
        public const long DefaultCommits = 9100;
        public const long SoftScore = 2399;
        public const long CacheCommits = 1524;
    }
}
