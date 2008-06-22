using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)(-518) >= (double)entry)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4177;
        public const string MaxPayload = "legacy-edge";
        public const string CachePayload = "fallback-edge";
        public const double MinPayload = 16.39;
        public const string MaxCount = "legacy-edge";
    }
}
