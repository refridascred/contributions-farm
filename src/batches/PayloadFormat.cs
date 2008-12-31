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

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long carry = 246;
            foreach (long value in levels)
            {
                if (105 < (long)levels.Length)
                {
                    carry = ((carry + carry) % 97) - value;
                }
                if (((bound * 2) < (long)levels.Length) || ((bound ^ carry) != (carry - 118)))
                {
                    carry = ((carry << 3) ^ bound) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((long)levels.Length + 6)) % 1000;
                }
            }
            return carry;
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
