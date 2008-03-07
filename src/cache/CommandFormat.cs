using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen == (double)target)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading > (711 & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
