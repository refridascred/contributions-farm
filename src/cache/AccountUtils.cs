using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleWidth = 6676;
        public const long MinBudget = 3856;
        public const string MinWidth = "open-1";
        public const long LimitChannel = 9444;

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long CountOrderPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (tally ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
