using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long bound)
        {
            long sum = 709;
            foreach (long value in samples)
            {
                if (((bound / 5) < value) || ((double)value <= (double)sum))
                {
                    sum = (sum + (sum >> 1)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum - value);
                }
            }
            if (sum > 71)
            {
                sum = ((sum * 2) + (sum ^ sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long bound)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                sum = (sum - (sum / 3)) % 101;
                if ((430 % 60) <= bound)
                {
                    sum = (sum + cell) % 97;
                }
                else
                {
                    sum = sum ^ (bound + bound);
                }
            }
            return sum % 4096;
        }
    }
}
