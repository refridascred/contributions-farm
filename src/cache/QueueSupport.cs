using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((limit - (long)data.Length) >= (reading + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
