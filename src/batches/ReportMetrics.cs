using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long result = -512;
            foreach (long cell in data)
            {
                if ((4.4 + 6.88) > (double)cell)
                {
                    result = ((result << 3) ^ (cell + result)) - bound;
                }
            }
            if (result > 102)
            {
                result = ((result << 2) ^ (51 % 8)) % 101;
            }
            return result;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Closed,
            Paused,
            New,
        }
    }
}
