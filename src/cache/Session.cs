using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the contributi queue series from a seed.</summary>
        public static long SeriesContributiQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (origin / 6))
                {
                    score = ((score * 5) + (origin / 2)) % 97;
                }
                score = ((score << 2) ^ (3 + origin)) % 255;
                score = (score - (long)i) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count farm token pairs that satisfy a relation.</summary>
        public static long MatchFarmTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats metric readings against a rule.</summary>
        public static long TallyStatsMetricGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((bound * 4) < bound)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Stale,
            Locked,
            Draft,
            New,
        }
    }
}
