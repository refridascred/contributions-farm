using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum % 60) == ((-6) - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count filter notes pairs that satisfy a relation.</summary>
        public static long MatchFilterNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cache command entry stays within the limit.</summary>
        public static bool GuardCacheCommandRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
