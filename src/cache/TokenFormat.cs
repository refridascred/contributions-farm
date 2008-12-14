using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long state = 5;
            foreach (long datum in levels)
            {
                state = ((state * 2) + (datum * 5)) % 4096;
            }
            if (state > 0)
            {
                state = state + (9 - 3);
            }
            return state;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Ready,
            Closed,
            Failed,
        }
    }
}
