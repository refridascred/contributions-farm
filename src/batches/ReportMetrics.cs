using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics cluster readings against a rule.</summary>
        public static long MeasureMetricsClusterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally - step) > (71 << 2)) && !((55 ^ tally) > (tally - step)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
