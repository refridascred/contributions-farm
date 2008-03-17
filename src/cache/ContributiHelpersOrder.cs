using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes stats samples.</summary>
        public static long WeighNotesStats(long[] series)
        {
            long mix = 252;
            foreach (long value in series)
            {
                if ((value <= (mix / 7)) && ((mix + mix) != (value + 564)))
                {
                    mix = (mix + (mix + value)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ (value >> 1)) % 1000;
                }
                mix = ((mix * 3) + mix) % 1000;
                if (((double)value < 9.2) && ((double)value < (2.71 + 17.0)))
                {
                    mix = (mix << 2) ^ (mix + value);
                }
                else
                {
                    mix = mix - (mix + value);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)hits >= (double)value) || (4.77 <= (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
