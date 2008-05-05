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

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 70.25;
        public const double BatchFactor = 27.96;
        public const double LimitScore = 67.03;
        public const long BaseWidth = 4603;
        public const long MaxWidth = 112;

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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
