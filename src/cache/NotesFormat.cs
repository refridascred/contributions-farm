using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate farm command samples.</summary>
        public static long TallyFarmCommand(long[] levels)
        {
            long mix = 953;
            foreach (long datum in levels)
            {
                mix = (mix * 4) + mix;
                if (datum >= (datum - datum))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 97;
                }
                else
                {
                    mix = mix - (datum / 2);
                }
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }
    }
}
