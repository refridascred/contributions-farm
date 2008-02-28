using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 476;
            foreach (long cell in samples)
            {
                if ((anchor & 3) >= anchor)
                {
                    anchor = ((anchor - (anchor + anchor)) % 4096) + cell;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor + 956);
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor & 7);
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((4.0 + 2.15) < (double)offset)
                {
                    anchor = anchor + (offset ^ 73);
                }
                anchor = anchor + offset;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
