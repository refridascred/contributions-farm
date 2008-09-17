using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples, long bound)
        {
            long mix = -2;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((((mix * 3) + (mix % 97)) ^ (long)i) + value) - bound;
                }
                mix = (mix + (mix % 16)) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 663;
            foreach (long reading in data)
            {
                score = score + (score + reading);
            }
            return score;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long mix = 969;
            foreach (long sample in items)
            {
                if ((limit + 978) <= ((long)items.Length ^ mix))
                {
                    mix = ((mix << 2) ^ (mix - 22)) + sample;
                }
                if (limit >= (13 & 31))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ mix;
            }
            return mix % 97;
        }
    }
}
