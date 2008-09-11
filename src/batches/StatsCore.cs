using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((52 - seed) == (datum + datum)) && (datum <= (count + datum))) || !((count + count) <= (6 + datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the context account series from a seed.</summary>
        public static long StepContextAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 3) + ((long)i >> 2);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
