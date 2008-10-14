using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8307;
        public const string MinStats = "open-1";
        public const long BaseLevel = 6137;
        public const string RetryStats = "staging-edge";
        public const string IdleStats = "strict-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 1305;
        public const double SoftLevel = 11.51;
        public const long SoftBudget = 7459;
        public const long CacheNotes = 8002;

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long StepBufferCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if ((54 >> 5) >= ((long)i % 3))
                {
                    acc = (acc ^ target) % 1000;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples, long origin)
        {
            long result = 608;
            foreach (long value in samples)
            {
                if ((224 + value) < (result * 2))
                {
                    result = ((result << 3) ^ (origin - result)) % 65521;
                }
            }
            if (result > (-466))
            {
                result = ((result * 2) + (origin - origin)) % 4096;
            }
            return result;
        }
    }
}
