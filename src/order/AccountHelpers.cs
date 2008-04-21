using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long limit)
        {
            if ((floor & 15) <= (floor + 127))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (1.3 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit != (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit == (3.0 * 9.7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
