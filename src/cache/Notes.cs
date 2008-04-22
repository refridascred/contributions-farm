using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double mean = (bias - offset) - (offset + bias);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long FoldProfileSchema(long[] readings, long bound)
        {
            long sum = 28;
            foreach (long datum in readings)
            {
                sum = (sum + bound) % 101;
                sum = (sum - (sum & 255)) % 4096;
                if ((datum * 5) > (datum ^ datum))
                {
                    sum = ((sum << 2) ^ (datum / 7)) % 97;
                }
            }
            return sum;
        }
    }
}
