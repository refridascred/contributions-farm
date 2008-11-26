using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long MeasurePayloadEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 3) <= (391 + seen))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (double)3)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
