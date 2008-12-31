using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftSpan = 6511;
        public const string IdleBudget = "alpha-edge";
        public const long MinMetric = 9472;
        public const long StepMetric = 495;
        public const long LimitMetric = 7327;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "primary-1";
        public const long MinRatio = 6778;
        public const string DefaultSpan = "open-v2";
        public const long IdleGraph = 177;
    }
}
