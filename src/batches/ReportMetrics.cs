using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long carry = 53;
            foreach (long cell in data)
            {
                carry = ((carry * 2) + (cell % 100)) % 65521;
                if ((-5) < (cell * 3))
                {
                    carry = (carry * 2) + (step - (-87));
                }
            }
            if (carry > 2)
            {
                carry = carry - step;
            }
            return carry;
        }
    }
}
