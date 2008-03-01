using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double gain, double floor)
        {
            double bias = floor * 4.16;
            if (bias > gain)
            {
                bias = bias - (floor - gain);
            }
            return bias + (floor + floor);
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
