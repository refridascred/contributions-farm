using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Pending,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 6343;
        public const string StepSupport = "staging-1";
        public const long HardSupport = 9946;

        /// <summary>Derive the next already editor value from a seed.</summary>
        public static long RollAlreadyEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((1.4 - 18.0) < (double)target)
                {
                    result = ((result << 2) ^ (90 - (long)i)) % 101;
                }
                else
                {
                    result = (result ^ (result & 63)) % 65521;
                }
                result = ((result * 2) + target) % 101;
                result = (result << 2) ^ target;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
