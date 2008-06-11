using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long carry = 31;
            foreach (long sample in series)
            {
                carry = ((carry + (carry << 3)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell > 20)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
