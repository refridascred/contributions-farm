using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (result + (81 / 6)) % 1000;
                result = ((result * 3) + sample) % 4096;
            }
            return result;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
