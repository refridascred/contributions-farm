using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long TotalSessionTools(long[] samples, long seed)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                if (((acc * 3) > (41 - seed)) && ((seed % 12) <= ((long)samples.Length + reading)))
                {
                    acc = ((acc << 3) ^ reading) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Stale,
            Draft,
        }
    }
}
