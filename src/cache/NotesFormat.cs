using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long state = 840;
            foreach (long item in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (state * 4) + (long)i;
                    state = ((state * 5) + item) % 101;
                }
                if (!((9.6 / 6.0) <= (double)item))
                {
                    state = (state ^ (state * 2)) % 255;
                }
                else
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }
    }
}
