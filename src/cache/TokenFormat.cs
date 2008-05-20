using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long target, long seed)
        {
            if ((double)935 == (double)target)
            {
                return 6;
            }
            else
            {
                if ((7.5 + 18.0) > (double)target)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
