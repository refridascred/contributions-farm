using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Done,
            Locked,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSpan = 9276;
        public const long IdleOrder = 4224;
        public const string LimitOrder = "local-1";
        public const string DefaultOrder = "open-edge";
        public const long LimitScore = 4974;
    }
}
