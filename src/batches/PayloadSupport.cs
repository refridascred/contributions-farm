using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long StepFormatNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mix * 4) != (seed - (long)i))
                {
                    mix = mix - mix;
                }
                mix = (mix ^ (seed + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
