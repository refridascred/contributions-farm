using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long step)
        {
            long sum = 4;
            foreach (long reading in series)
            {
                if (step < (step * 3))
                {
                    sum = (sum ^ (sum * 5)) - reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
