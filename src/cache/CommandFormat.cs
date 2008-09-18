using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long offset)
        {
            if (((2.5 * 3.39) > (double)offset) && ((offset >> 1) > (offset << 1)))
            {
                return 0;
            }
            else
            {
                if (!((double)bound > (2.6 / 5.0)))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ offset) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset > (9 + offset)) || (87 <= (offset ^ 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LocateEntryBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
