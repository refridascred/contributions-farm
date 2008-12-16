using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9586;
        public const double WindowRatio = 46.18;
        public const double MinWidth = 61.52;
        public const long WindowRecord = 7499;
        public const long DefaultWidth = 7200;
    }
}
