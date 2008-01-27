using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long FoldAlreadyGithubfarm(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (result >> 3)) % 65521) + sample;
            }
            if (result < 37)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long step, long bound)
        {
            if (step > (12 >> 4))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
