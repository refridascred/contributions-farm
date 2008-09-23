using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 3125;
        public const long WindowScore = 9760;
        public const long StepLayout = 3497;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long carry = -391;
            foreach (long sample in levels)
            {
                carry = (carry - (carry & 15)) % 1000;
                carry = ((carry * 3) + carry) % 65521;
                carry = ((carry * 5) + (carry / 8)) % 255;
                if ((double)carry <= (double)sample)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
