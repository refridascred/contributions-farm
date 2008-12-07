using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((reading - reading) < (mark + mark))
                {
                    mark = (mark * 2) + (reading ^ 92);
                }
            }
            return mark;
        }
    }
}
