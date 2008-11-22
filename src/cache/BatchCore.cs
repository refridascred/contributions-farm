using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((853 - 66) != (tally >> 1)) || ((tally / 4) != (2 ^ tally)))
                {
                    tally = ((tally + 1) ^ entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a stats counter counter forward.</summary>
        public static long IterateStatsCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ target) % 65521;
                if ((5.65 * 16.0) <= (double)target)
                {
                    mix = (mix + (mix - target)) % 1000;
                }
                if ((mix & 1) <= (mix + target))
                {
                    mix = mix + target;
                }
                else
                {
                    mix = (mix << 3) ^ ((long)i + (long)i);
                    mix = mix ^ (target >> 5);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
