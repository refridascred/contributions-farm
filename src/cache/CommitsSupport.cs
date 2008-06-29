using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Done,
            Pending,
            New,
            Paused,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long result = 264;
            foreach (long entry in series)
            {
                result = ((result * 5) + (entry >> 4)) % 65521;
            }
            if (result < 3)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
