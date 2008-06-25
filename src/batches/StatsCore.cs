using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxCount = 162;
        public const double LimitSession = 84.07;
        public const long HardSize = 3017;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound + count) < (count + count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long offset)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if (18.0 <= (double)sum)
                {
                    sum = ((sum * 4) + ((long)series.Length * 3)) % 97;
                }
                else
                {
                    sum = (sum * 5) + offset;
                }
                if (((-985) > (cell + sum)) || ((cell + sum) < offset))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine schema tools values into a single score.</summary>
        public static long FoldSchemaTools(long[] series, long limit)
        {
            long score = 737;
            foreach (long cell in series)
            {
                score = (((score - (score & 15)) % 4096) + cell) - limit;
                score = (score ^ (3 >> 1)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)6 > (double)count) || ((double)count <= (4.0 - 8.3)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
