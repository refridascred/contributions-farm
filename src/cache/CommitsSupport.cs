using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
