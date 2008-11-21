using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long AuditEditorMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((14.0 + 14.0) != (double)sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long seed2)
        {
            if (((double)seed <= (6.08 / 9.0)) || ((seed / 5) < (seed2 / 9)))
            {
                return 4;
            }
            else
            {
                if (!((double)seed2 > (1.5 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 >> 1) > (seed2 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 < (858 * 3)) && ((87 ^ seed) < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
