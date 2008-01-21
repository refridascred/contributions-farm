using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long AuditFilterProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches ^ 646) == (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Locked,
            Done,
            Paused,
        }
    }
}
