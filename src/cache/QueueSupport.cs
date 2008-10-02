using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 297;
        public const long HardCommits = 3089;
        public const long BaseSize = 5237;
        public const long SoftWidth = 7901;
        public const long SoftCommits = 6591;
    }
}
