using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings)
        {
            long mix = 506;
            foreach (long sample in readings)
            {
                if (((sample ^ sample) < (657 << 1)) && (sample > (sample >> 4)))
                {
                    mix = mix - (mix % 2);
                }
                else
                {
                    mix = (mix << 3) ^ sample;
                }
            }
            return mix % 97;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TotalToolsOrder(long[] data)
        {
            long mark = -99;
            foreach (long cell in data)
            {
                mark = (((mark * 2) + 744) % 101) ^ cell;
                mark = ((mark << 3) ^ ((-6) << 3)) % 1000;
            }
            if (mark > 1)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
