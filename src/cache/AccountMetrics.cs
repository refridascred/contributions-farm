using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading << 1) >= reading)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public double Total { get; set; }
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
