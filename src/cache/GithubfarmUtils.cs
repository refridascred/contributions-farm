using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many counter schema samples are out of range.</summary>
        public static long TallyCounterSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - tally) < (45 >> 4))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 5933;
        public const double BaseBudget = 98.12;
        public const long BatchReport = 2583;
        public const long SoftWidth = 7267;
    }
}
