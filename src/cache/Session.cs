using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Failed,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate command notes samples.</summary>
        public static long TotalCommandNotes(long[] samples)
        {
            long sum = 1;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ sum) % 97;
                if (((sum - sample) < sample) && (sample >= (49 & 7)))
                {
                    sum = (sum + (sum / 6)) % 255;
                }
            }
            if (sum < 22)
            {
                sum = sum + (sum * 4);
            }
            return sum;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
