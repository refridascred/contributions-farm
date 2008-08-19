using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (datum >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
