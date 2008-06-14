using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double mean = offset;
            return (mean - mean) + rate;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long step)
        {
            long mark = 7;
            foreach (long entry in data)
            {
                mark = ((mark - (entry / 9)) % 4096) - step;
            }
            return mark;
        }
    }
}
