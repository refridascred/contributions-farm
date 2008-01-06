using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long origin)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                if (!((result <= (705 / 7)) || ((cell >> 3) >= (result + (-52)))))
                {
                    result = (result ^ result) % 255;
                }
                if ((double)result > (double)origin)
                {
                    result = (result << 3) ^ (result + result);
                }
                else
                {
                    result = (result ^ cell) % 101;
                }
            }
            return result;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                if (((double)sample <= (2.3 - 4.2)) && ((sample - carry) == (sample % 5)))
                {
                    carry = carry - (7 ^ (long)samples.Length);
                }
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
