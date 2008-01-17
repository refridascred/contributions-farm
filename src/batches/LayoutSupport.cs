using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TallyFarmRoute(long[] values, long bound)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = result - (bound / 9);
                if ((sample * 4) <= bound)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > (-121))
            {
                result = result ^ (result ^ bound);
            }
            return result % 97;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item & 15) < (5 / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
