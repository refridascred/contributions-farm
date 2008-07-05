using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (((entry - entry) == (entry & 1)) && ((anchor - entry) != (entry - entry)))
                {
                    anchor = anchor ^ 987;
                }
            }
            return anchor;
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long ScoreEditorProfile(long[] data)
        {
            long state = -1;
            foreach (long cell in data)
            {
                if (!((cell + cell) < (state / 4)))
                {
                    state = (state ^ cell) % 4096;
                }
                if (!((1 & 31) < state))
                {
                    break;
                }
            }
            if (state > (-19))
            {
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }
    }
}
