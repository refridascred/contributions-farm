using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Closed,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data)
        {
            long acc = 676;
            foreach (long cell in data)
            {
                if (!((double)acc < 18.0))
                {
                    acc = (acc << 2) ^ (cell % 5);
                }
                if (((acc + acc) < (acc - cell)) || ((96 ^ 5) > (long)data.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
