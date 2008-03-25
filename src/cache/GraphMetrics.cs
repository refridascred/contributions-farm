using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long AuditBufferFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) < (98 >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long floor)
        {
            if ((double)offset >= (5.0 - 8.71))
            {
                return 2;
            }
            else
            {
                if (((offset + offset) < (offset ^ floor)) || (17.0 <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (offset > (offset % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) >= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (tally / 8)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
