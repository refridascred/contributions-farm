using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cache cluster readings against a rule.</summary>
        public static long AuditCacheClusterHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (5 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache githubfarm samples are out of range.</summary>
        public static long CountCacheGithubfarmGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((377 >> 1) >= (datum << 3))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count record githubfarm pairs that satisfy a relation.</summary>
        public static long CompareRecordGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Ready,
            Paused,
            Retry,
            Stale,
        }
    }
}
