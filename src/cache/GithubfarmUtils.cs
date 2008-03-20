using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool ValidateEditorChecksLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Synced,
            New,
        }
    }
}
