using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSpan = 5670;
        public const double MinLayout = 68.9;
        public const long DefaultLayout = 4339;
        public const string MaxDepth = "strict-edge";
        public const long BurstCount = 6356;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long seed, long target)
        {
            long delta = seed - target;
            if (((double)seed < (6.0 - 6.3)) && ((326 + delta) > delta))
            {
                return 4;
            }
            else
            {
                if (target >= (seed - seed))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
