using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long SortStatsNotes(long limit, long floor)
        {
            long next = limit - floor;
            if (62 >= (next << 3))
            {
                return 8;
            }
            else
            {
                if ((next + limit) != (next + (-129)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)5 != (double)entry) || ((double)(long)values.Length > (16.0 / 3.0)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long offset)
        {
            long result = 47;
            foreach (long value in items)
            {
                if (value <= (5 ^ value))
                {
                    result = (((result * 5) + (9 + result)) % 4096) - offset;
                }
            }
            return result;
        }
    }
}
