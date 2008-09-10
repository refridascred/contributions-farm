using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((result + origin) < (origin << 2))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a commits schema counter forward.</summary>
        public static long StepCommitsSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((double)mix < 0.01) || ((double)mix != (5.1 + 2.8)))
                {
                    mix = (mix * 2) + (target - mix);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
