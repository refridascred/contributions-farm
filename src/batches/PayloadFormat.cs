using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1543;
        public const double StepChecks = 9.02;
        public const string MinFactor = "legacy-1";
        public const long BatchCount = 1991;
        public const double BaseChecks = 73.9;
    }
}
