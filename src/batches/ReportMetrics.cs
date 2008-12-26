using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                long tally = ((long)i * 5) + origin;
                mix = ((mix * 3) + (mix - tally)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((67 - reading) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
