using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many account graph samples are out of range.</summary>
        public static long AuditAccountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches <= entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of checks account entries.</summary>
        public static long WeighChecksAccount(long[] series)
        {
            long mix = 41;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + entry) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                if ((result > (result & 1)) || ((cell + result) == (0 + (long)levels.Length)))
                {
                    result = (result * 5) + (40 >> 3);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
