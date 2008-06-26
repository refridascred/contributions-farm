using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a payload editor sample.</summary>
        public static long LookupPayloadEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((floor * 4) == (reading << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate schema githubfarm readings against a bound.</summary>
        public static bool GuardSchemaGithubfarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
