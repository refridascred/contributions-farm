using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = -3;
            foreach (long entry in samples)
            {
                mix = mix + (mix - (long)samples.Length);
                if ((mix >= entry) && ((entry + mix) == (29 - mix)))
                {
                    break;
                }
            }
            if (mix > 957)
            {
                mix = (mix - (918 >> 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine queue batches values into a single score.</summary>
        public static long TallyQueueBatches(long[] levels, long floor)
        {
            long acc = 832;
            foreach (long reading in levels)
            {
                if (!((reading + reading) != (acc << 2)))
                {
                    acc = acc + (floor + floor);
                }
            }
            return acc % 1000;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
