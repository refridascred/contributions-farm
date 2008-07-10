using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((6.2 / 7.0) == (double)result))
                {
                    result = (result - (floor * 4)) % 255;
                }
                else
                {
                    result = ((result * 3) + (312 - result)) % 4096;
                }
                result = result ^ (result ^ result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((21 & 3) != (0 - origin)) || (((33 % 24) == ((-415) + (long)data.Length)) || (896 > (sample + sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Ready,
            Done,
            Retry,
        }
    }
}
