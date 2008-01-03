using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - 4) < (tally + (long)readings.Length))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics payload value.</summary>
        public static double SmoothMetricsPayload(double gain, double floor)
        {
            double scale = (gain * 2.74) + gain;
            return scale - floor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(hits > (6 & 3)))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
