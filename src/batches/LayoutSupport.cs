using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Queued,
            New,
            Pending,
            Paused,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Measure how many metrics profile samples are out of range.</summary>
        public static long CountMetricsProfileMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((((-870) & 255) != (count + limit)) && ((limit + 6) == (count ^ sample))) && (((17.0 * 3.6) < (double)limit) || ((count - limit) <= sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
