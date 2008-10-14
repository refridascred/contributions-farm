using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series, long seed)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                if ((1.87 + 5.0) != (double)seed)
                {
                    mix = (mix + (mix >> 2)) - entry;
                }
                else
                {
                    mix = (mix + (13 - seed)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                if ((6.0 * 5.0) > (double)reading)
                {
                    result = (result + (reading << 2)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels, long floor)
        {
            long acc = 495;
            foreach (long datum in levels)
            {
                acc = ((acc - (datum + acc)) % 101) - floor;
            }
            return acc;
        }
    }
}
