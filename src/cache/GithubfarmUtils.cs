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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i + result) == (5 - step)))
                {
                    result = (result + ((long)i + step)) % 97;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
