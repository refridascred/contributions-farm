using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long offset2)
        {
            long prev = offset - offset2;
            if (((prev >> 4) > (offset ^ prev)) && ((139 + prev) > (offset & 31)))
            {
                return 1;
            }
            else
            {
                if ((prev & 1) != (prev + offset))
                {
                    return 3;
                }
                else
                {
                    if ((prev % 97) < (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitInterval = 5847;
        public const double HardCount = 61.96;
        public const string BaseSpan = "latest-1";

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long AuditStatsRecordOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < (bound / 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
