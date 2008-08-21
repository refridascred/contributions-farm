using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the account window series from a seed.</summary>
        public static long IterateAccountWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (score / 9)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
