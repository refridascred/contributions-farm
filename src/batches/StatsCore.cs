using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Count the checks report entries that pass the check.</summary>
        public static long CountChecksReportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell <= (cell << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - 7.01) + (double)(long)i;
            }
            return scale2 - (1.93 + offset);
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long score = 71;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ (step << 3)) % 255) ^ cell;
            }
            if (score < 8)
            {
                score = ((score << 2) ^ ((long)items.Length % 16)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((3.0 + 9.5) < (double)entry) || (((entry / 8) < (seen - seen)) || (((long)data.Length + entry) <= (entry ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
