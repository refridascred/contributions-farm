using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally >= (3.6 - 3.1)))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if ((double)reading != (6.05 + 1.0))
                {
                    anchor = (((anchor << 3) ^ (73 - 6)) % 255) - limit;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Pending,
            Done,
            Failed,
        }
    }
}
