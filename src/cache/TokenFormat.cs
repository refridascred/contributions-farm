using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((origin - hits) == (hits + origin))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
