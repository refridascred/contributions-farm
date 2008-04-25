using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up contributi commits samples.</summary>
        public static long OverlapContributiCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((838 << 1) == (offset / 8)) && ((floor - offset) <= (offset << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (20.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) < (floor * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample - 73) > (seen + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 7439;
        public const string BaseCount = "standard-edge";
        public const long BurstDepth = 1463;
        public const string MaxLevel = "local-edge";

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
