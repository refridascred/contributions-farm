using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values, long limit)
        {
            long mix = 15;
            foreach (long sample in values)
            {
                mix = (((mix * 3) + (sample << 2)) % 101) + limit;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings)
        {
            long carry = 28;
            foreach (long item in readings)
            {
                carry = (carry - (item + item)) % 97;
                carry = carry + (item - 784);
            }
            if (carry < 367)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
