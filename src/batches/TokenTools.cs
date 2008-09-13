using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 8439;
        public const double SoftCommand = 14.91;
        public const long BurstCommand = 5208;
        public const long IdleCommand = 705;

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long AuditEditorContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally ^ tally) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 3191;
        public const double LimitPayload = 33.66;
        public const long BurstPayload = 8891;
        public const long IdleScore = 887;
        public const long StepScore = 2041;
    }
}
