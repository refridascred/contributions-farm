using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long TallyContextStream(long[] levels)
        {
            long anchor = 16;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ entry) % 101;
            }
            return anchor % 97;
        }
    }
}
