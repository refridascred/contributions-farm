using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Failed,
            Idle,
        }

        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool VerifyWindowBatchesRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = (sum + (item / 6)) % 4096;
                if ((item - sum) > (sum >> 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
