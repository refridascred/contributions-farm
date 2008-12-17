using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!(offset >= (714 & 127)))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long sum = 73;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum - sum)) % 1000) + entry;
            }
            return sum;
        }

        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long SeekMetricCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
