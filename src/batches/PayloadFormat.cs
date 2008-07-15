using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long limit)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                if (!(cell >= (cell << 2)))
                {
                    carry = (carry - (carry - limit)) % 65521;
                }
                else
                {
                    carry = (carry ^ (cell * 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
