using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long sum = 944;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ sample) % 255;
                if ((4.0 - 7.08) <= (double)sample)
                {
                    break;
                }
            }
            if (sum < 93)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }
    }
}
