using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (6.96 < (double)tally)
                {
                    tally = ((tally + 3) + entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((origin ^ 7) <= ((-80) ^ 299))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (floor ^ floor)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
