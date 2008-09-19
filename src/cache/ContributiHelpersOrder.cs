using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 43;
            foreach (long entry in items)
            {
                if ((entry < (mix + mix)) || (((-71) + mix) < (mix + entry)))
                {
                    mix = ((mix << 3) ^ (98 - 7)) % 101;
                }
                if ((entry ^ mix) <= (entry - entry))
                {
                    mix = (mix - (mix ^ mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 5.32)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
