using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
