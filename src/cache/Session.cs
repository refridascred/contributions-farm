using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 966;
            foreach (long entry in values)
            {
                state = (state * 3) + entry;
            }
            return state % 65521;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Find the first cache command entry that matches the target.</summary>
        public static long LookupCacheCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
