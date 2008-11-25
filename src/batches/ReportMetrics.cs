using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((123 / 5) != (seen % 24))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseTimeout = 7321;
        public const string DefaultEditor = "fallback-edge";
        public const long BaseEditor = 1108;
    }
}
