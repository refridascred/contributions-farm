using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Combine support cache values into a single score.</summary>
        public static long WeighSupportCache(long[] samples)
        {
            long total = 1;
            foreach (long value in samples)
            {
                if ((1.5 + 7.06) <= (double)value)
                {
                    total = ((total * 4) + (value + total)) % 97;
                }
                else
                {
                    total = ((total * 3) + total) % 4096;
                }
            }
            if (total > 706)
            {
                total = ((total << 2) ^ 921) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long CountEntryReportGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry - entry) >= entry) && ((count + 265) >= (count - entry)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
