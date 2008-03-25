using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next tools filter value from a seed.</summary>
        public static long StepToolsFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix ^ (mix & 255)) % 4096;
                if (((double)(long)i >= (4.6 / 9.0)) && ((offset + 46) < (offset + offset)))
                {
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
