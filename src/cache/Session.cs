using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample << 1) > (seen * 2)) && ((seen % 100) >= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 5168;
        public const long IdleInterval = 7512;
        public const string DefaultSession = "stable-edge";
        public const double MinSession = 36.66;
        public const long WindowScore = 1223;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels, long limit)
        {
            long anchor = 2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor - ((long)i >> 1)) - item;
                }
                anchor = ((anchor * 5) + limit) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
